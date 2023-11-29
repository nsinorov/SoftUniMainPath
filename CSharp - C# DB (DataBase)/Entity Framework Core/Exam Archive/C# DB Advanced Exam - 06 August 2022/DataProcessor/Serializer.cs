namespace Footballers.DataProcessor
{
    using Data;
    using Footballers.Data.Enums;
    using Footballers.DataProcessor.ExportDto;
    using Footballers.Utilities;
    using Newtonsoft.Json;
    using System.Globalization;

    public class Serializer
    {
        //XML Export
        public static string ExportCoachesWithTheirFootballers(FootballersContext context)
        {
            //Selecting the Coaches
            var coaches = context.Coaches
                .Where(c => c.Footballers.Any())
                .Select(c => new ExportCoachDto
                { 
                    FootballersCount = c.Footballers.Count,
                    Name = c.Name,
                    Footballers = c.Footballers
                    .Select(f => new ExportFootballerDto
                    {
                        Name = f.Name,
                        Position = f.PositionType.ToString()
                    })
                    .OrderBy(f => f.Name)
                    .ToArray()
                })
                .OrderByDescending(c => c.FootballersCount)
                .ThenBy(c => c.Name)
                .ToArray();

            //Returning the collection as XML
            XmlHelper xmlHelper = new XmlHelper();
            return xmlHelper.Serialize<ExportCoachDto[]>(coaches, "Coaches");
        }

        //JSON Export
        public static string ExportTeamsWithMostFootballers(FootballersContext context, DateTime date)
        {
            //Selecting the Teams
            var teams = context.Teams
                .Where(t => t.TeamsFootballers.Any(tf => tf.Footballer.ContractStartDate >= date))
                .AsEnumerable()
                .Select(t => new
                {
                    Name = t.Name,
                    Footballers = t.TeamsFootballers
                    .Where(tf => tf.Footballer.ContractStartDate >= date)
                    .OrderByDescending(tf => tf.Footballer.ContractEndDate)
                    .ThenBy(tf => tf.Footballer.Name)
                    .Select(tf => new
                    {
                        FootballerName = tf.Footballer.Name,
                        ContractStartDate = tf.Footballer.ContractStartDate.ToString("d", CultureInfo.InvariantCulture),
                        ContractEndDate = tf.Footballer.ContractEndDate.ToString("d", CultureInfo.InvariantCulture),
                        BestSkillType = tf.Footballer.BestSkillType.ToString(),
                        PositionType = tf.Footballer.PositionType.ToString()
                    })
                    .ToArray()
                })
                .OrderByDescending(t => t.Footballers.Length)
                .ThenBy(t => t.Name)
                .Take(5)
                .ToArray();

            //Returning the collection as JSON
            return JsonConvert.SerializeObject(teams, Formatting.Indented);
        }
    }
}