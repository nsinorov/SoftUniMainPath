namespace Theatre.DataProcessor
{
    using Newtonsoft.Json;
    using System;
    using System.IO;
    using Theatre.Data;
    using Theatre.DataProcessor.ExportDto;
    using Theatre.Utilities;

    public class Serializer
    {
        //JSON Export
        public static string ExportTheatres(TheatreContext context, int numbersOfHalls)
        {
            //Selecting the Theatres
            var theatres = context.Theatres
                .AsEnumerable()
                .Where(th => th.NumberOfHalls >= numbersOfHalls && th.Tickets.Count >= 20)
                .Select(th => new
                {
                    Name = th.Name,
                    Halls = th.NumberOfHalls,
                    TotalIncome = th.Tickets.Where(t => t.RowNumber >= 1 && t.RowNumber <= 5).Sum(t => t.Price),
                    Tickets = th.Tickets
                    .Where(t => t.RowNumber >= 1 && t.RowNumber <= 5)
                    .Select(t => new
                    {
                        Price = t.Price,
                        RowNumber = t.RowNumber
                    })
                    .OrderByDescending(t => t.Price)
                    .ToArray()
                })
                .OrderByDescending(th => th.Halls)
                .ThenBy(th => th.Name)
                .ToArray();

            //Returning the result as JSON
            return JsonConvert.SerializeObject(theatres, Formatting.Indented);
        }

        public static string ExportPlays(TheatreContext context, double raiting)
        {
            //Selecting the Plays
            var plays = context.Plays
                .Where(p => p.Rating <= raiting)
                .AsEnumerable()
                .Select(p => new ExportPlayDto()
                {
                    Title = p.Title,
                    Duration = p.Duration.ToString("c"),
                    Rating = p.Rating == 0 ? "Premier" : p.Rating.ToString(),
                    Genre = p.Genre.ToString(),
                    Actors = p.Casts
                    .Where(c => c.IsMainCharacter)
                    .Select(c => new ExportCastDto
                    {
                        FullName = c.FullName,
                        IsMainCharacter = $"Plays main character in '{p.Title}'."
                    })
                    .OrderByDescending(c => c.FullName)
                    .ToArray()
                })
                .OrderBy(p => p.Title)
                .ThenByDescending(p => p.Genre)
                .ToArray();

            //Returning the result as XML
            XmlHelper xmlHelper = new XmlHelper();
            return xmlHelper.Serialize<ExportPlayDto[]>(plays, "Plays");
        }
    }
}
