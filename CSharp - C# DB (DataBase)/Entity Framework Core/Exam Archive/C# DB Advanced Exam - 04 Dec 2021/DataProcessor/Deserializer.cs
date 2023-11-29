namespace Theatre.DataProcessor
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.SqlTypes;
    using System.Globalization;
    using System.Text;
    using System.Text.Json.Serialization;
    using Theatre.Common;
    using Theatre.Data;
    using Theatre.Data.Enums;
    using Theatre.Data.Models;
    using Theatre.DataProcessor.ImportDto;
    using Theatre.Utilities;

    public class Deserializer
    {
        //Messages
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfulImportPlay
            = "Successfully imported {0} with genre {1} and a rating of {2}!";

        private const string SuccessfulImportActor
            = "Successfully imported actor {0} as a {1} character!";

        private const string SuccessfulImportTheatre
            = "Successfully imported theatre {0} with #{1} tickets!";


        //XML Import
        public static string ImportPlays(TheatreContext context, string xmlString)
        {
            //Deserializing the XML to a Play DTO
            XmlHelper xmlHelper = new XmlHelper();
            ImportPlayDto[] playDtos = xmlHelper.Deserialize<ImportPlayDto[]>(xmlString, "Plays");

            //Selecting only the Valid Plays
            HashSet<Play> validPlays = new HashSet<Play>();
            StringBuilder sb = new StringBuilder();

            foreach (var playDto in playDtos)
            {
                //Invalid Play
                if (!IsValid(playDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (!Enum.TryParse<Genre>(playDto.Genre, out Genre genre))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (!TimeSpan.TryParseExact(playDto.Duration, "c", CultureInfo.InvariantCulture, out TimeSpan duration))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                if (duration.Hours < CommonConstraints.PlayDurationMinLengthInHours)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                //Valid Play Adding
                validPlays.Add(new Play()
                {
                    Title = playDto.Title,
                    Duration = duration,
                    Rating = (float)playDto.Rating,
                    Genre = genre,
                    Description = playDto.Description,
                    Screenwriter = playDto.Screenwriter
                });
                sb.AppendLine(String.Format(SuccessfulImportPlay, playDto.Title, playDto.Genre, playDto.Rating));
            }
            //Adding And Saving
            context.Plays.AddRange(validPlays);
            context.SaveChanges();

            //Output
            return sb.ToString().TrimEnd();
        }

        //XML Import
        public static string ImportCasts(TheatreContext context, string xmlString)
        {
            //Deserializing the XML to a Cast DTO
            XmlHelper xmlHelper = new XmlHelper();
            ImportCastDto[] castDtos = xmlHelper.Deserialize<ImportCastDto[]>(xmlString, "Casts");

            //Selecting only the Valid Casts
            HashSet<Cast> validCasts = new HashSet<Cast>();
            StringBuilder sb = new StringBuilder();

            foreach (var castDto in castDtos)
            {
                //Invalid Cast
                if (!IsValid(castDto) || String.IsNullOrEmpty(castDto.FullName))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                //Valid Cast
                validCasts.Add(new Cast()
                {
                    FullName = castDto.FullName,
                    IsMainCharacter = castDto.IsMainCharacter,
                    PhoneNumber = castDto.PhoneNumber,
                    PlayId = castDto.PlayId
                });
                sb.AppendLine(String.Format(SuccessfulImportActor, castDto.FullName, castDto.IsMainCharacter ? "main" : "lesser"));
            }
            //Adding And Saving
            context.Casts.AddRange(validCasts);
            context.SaveChanges();

            //Output
            return sb.ToString().TrimEnd();
        }

        //JSON Import
        public static string ImportTtheatersTickets(TheatreContext context, string jsonString)
        {
            //Deserializing the JSON to a Theater DTO
            ImportTheatreDto[] theatreDtos = JsonConvert.DeserializeObject<ImportTheatreDto[]>(jsonString);

            //Selecting only the Valid Casts
            HashSet<Theatre> validTheatres = new HashSet<Theatre>();
            StringBuilder sb = new StringBuilder();

            foreach (var theatreDto in theatreDtos)
            {
                //Invalid Theatre
                if (!IsValid(theatreDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                //Valid Theatre
                Theatre validTheatre = new Theatre()
                { 
                    Name = theatreDto.Name,
                    NumberOfHalls = theatreDto.NumberOfHalls,
                    Director = theatreDto.Director
                };

                foreach (var ticketDto in theatreDto.Tickets)
                {
                    //Invalid Theatre
                    if (!IsValid(ticketDto))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    //Valid Theatre
                    validTheatre.Tickets.Add(new Ticket()
                    {
                        Price = ticketDto.Price,
                        RowNumber = ticketDto.RowNumber,
                        PlayId = ticketDto.PlayId
                    });
                }
                validTheatres.Add(validTheatre);
                sb.AppendLine(String.Format(SuccessfulImportTheatre, validTheatre.Name, validTheatre.Tickets.Count));
            }
            //Adding And Saving
            context.Theatres.AddRange(validTheatres);
            context.SaveChanges();

            //Output
            return sb.ToString().TrimEnd();
        }

        //DTOs Validation
        private static bool IsValid(object obj)
        {
            var validator = new ValidationContext(obj);
            var validationRes = new List<ValidationResult>();

            var result = Validator.TryValidateObject(obj, validator, validationRes, true);
            return result;
        }
    }
}
