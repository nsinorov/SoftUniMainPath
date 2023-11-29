namespace Footballers.DataProcessor
{
    using Footballers.Data;
    using Footballers.Data.Enums;
    using Footballers.Data.Models;
    using Footballers.DataProcessor.ImportDto;
    using Footballers.Utilities;
    using Microsoft.EntityFrameworkCore.Storage;
    using Newtonsoft.Json;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Text;

    public class Deserializer
    {
        //Messages
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedCoach
            = "Successfully imported coach - {0} with {1} footballers.";

        private const string SuccessfullyImportedTeam
            = "Successfully imported team - {0} with {1} footballers.";

        //XML Import
        public static string ImportCoaches(FootballersContext context, string xmlString)
        {
            //Deserializing the XML to Coach DTOs
            var xmlHelper = new XmlHelper();
            ImportCoachDto[] coachDtos = xmlHelper.Deserialize<ImportCoachDto[]>(xmlString, "Coaches");

            //Selecting only the Valid Coaches and their Footballers
            HashSet<Coach> validCoaches = new HashSet<Coach>();
            StringBuilder sb = new StringBuilder();

            //Coaches Validation
            foreach (var coachDto in coachDtos)
            {
                //Invalid Coach
                if (!IsValid(coachDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                if (String.IsNullOrEmpty(coachDto.Nationality))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                //Valid Coach
                Coach validCoach = new Coach()
                {
                    Name = coachDto.Name,
                    Nationality = coachDto.Nationality
                };

                //Footballers Validation
                foreach (var footballerDto in coachDto.Footballers)
                {
                    DateTime contractStartDate;
                    DateTime contractEndDate;

                    //Invalid Footballer
                    if (!IsValid(footballerDto))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    if (!DateTime.TryParseExact(footballerDto.ContractStartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out contractStartDate)
                        || !DateTime.TryParseExact(footballerDto.ContractEndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out contractEndDate))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    if (contractStartDate > contractEndDate)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    //Valid Footballer
                    Footballer validFootballer = new Footballer()
                    {
                        Name = footballerDto.Name,
                        ContractStartDate = contractStartDate,
                        ContractEndDate = contractEndDate,
                        BestSkillType = (BestSkillType)footballerDto.BestSkillType,
                        PositionType = (PositionType)footballerDto.PositionType
                    };
                    //Adding the Valid Footballer to it's Valid Coach
                    validCoach.Footballers.Add(validFootballer);
                }
                //Adding the Valid Coach to it's Collection
                validCoaches.Add(validCoach);
                sb.AppendLine(String.Format(SuccessfullyImportedCoach, validCoach.Name, validCoach.Footballers.Count));
            }
            //Adding the Valid Coaches to the database and Saving
            context.Coaches.AddRange(validCoaches);
            context.SaveChanges();

            //Output
            return sb.ToString().TrimEnd();
        }

        //JSON Import
        public static string ImportTeams(FootballersContext context, string jsonString)
        {
            //Deserializing the JSON to Team DTOs
            ImportTeamDto[] teamDtos = JsonConvert.DeserializeObject<ImportTeamDto[]>(jsonString);

            //Selecting only the Valid Teams and Footballers
            HashSet<Team> validTeams = new HashSet<Team>();
            int[] footballersIds = context.Footballers.Select(f => f.Id).ToArray();
            StringBuilder sb = new StringBuilder();

            //Teams Validation
            foreach (var teamDto in teamDtos)
            {
                //Invalid Team
                if (!IsValid(teamDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                if (teamDto.Trophies == 0 || String.IsNullOrEmpty(teamDto.Nationality))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                //Valid Team
                Team validTeam = new Team()
                { 
                    Name = teamDto.Name,
                    Nationality = teamDto.Nationality,
                    Trophies = teamDto.Trophies
                };

                //Footballers Validation
                foreach (var footballerId in teamDto.FootballersIds.Distinct())
                {
                    //Invalid Footballer Id
                    if (!footballersIds.Contains(footballerId))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    //Valid Footballer Id
                    validTeam.TeamsFootballers.Add(new TeamFootballer()
                    {
                        TeamId = validTeam.Id,
                        FootballerId = footballerId
                    });
                }
                //Adding the Valid Team to it's Collection
                validTeams.Add(validTeam);
                sb.AppendLine(String.Format(SuccessfullyImportedTeam, validTeam.Name, validTeam.TeamsFootballers.Count));
            }
            //Adding the Valid Coaches to the database and Saving
            context.Teams.AddRange(validTeams);
            context.SaveChanges();

            //Output
            return sb.ToString().TrimEnd();
        }

        //DTOs Validation
        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}
