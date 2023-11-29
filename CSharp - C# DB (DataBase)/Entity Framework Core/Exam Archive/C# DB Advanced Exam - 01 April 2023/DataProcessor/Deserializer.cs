namespace Boardgames.DataProcessor
{
    using System.ComponentModel.DataAnnotations;
    using System.Data.SqlTypes;
    using System.Text;
    using Boardgames.Data;
    using Boardgames.Data.Models;
    using Boardgames.Data.Models.Enums;
    using Boardgames.DataProcessor.ImportDto;
    using Boardgames.Utilities;
    using Castle.Core.Internal;
    using Newtonsoft.Json;

    public class Deserializer
    {
        //Messages
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedCreator
            = "Successfully imported creator – {0} {1} with {2} boardgames.";

        private const string SuccessfullyImportedSeller
            = "Successfully imported seller - {0} with {1} boardgames.";

        //Import XML
        public static string ImportCreators(BoardgamesContext context, string xmlString)
        {
            var xmlHelper = new XmlHelper();

            //Deserializing the XML to a Creator DTO
            ImportCreatorDto[] creatorDtos = xmlHelper.Deserialize<ImportCreatorDto[]>(xmlString, "Creators");

            //Adding only the valid DTOs to the database
            HashSet<Creator> validCreators = new HashSet<Creator>();
            StringBuilder sb = new StringBuilder();

            //Creator Validation
            foreach (var creatorDto in creatorDtos)
            {
                //Invalid Creator
                if (!IsValid(creatorDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                //Valid Creator
                Creator validCreator = new Creator()
                {
                    FirstName = creatorDto.FirstName,
                    LastName = creatorDto.LastName
                };

                //Current Creator's Boardgames Validation
                foreach (var boardgameDto in creatorDto.Boardgames)
                {
                    //Invalid Boardgame
                    if (!IsValid(boardgameDto) || boardgameDto.Name.IsNullOrEmpty())
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    //Valid Boardgame
                    Boardgame validBoardgame = new Boardgame()
                    { 
                        Name = boardgameDto.Name,
                        Rating = boardgameDto.Rating,
                        YearPublished = boardgameDto.YearPublished,
                        CategoryType = (CategoryType)boardgameDto.CategoryType,
                        Mechanics = boardgameDto.Mechanics
                    };

                    //Adding the Valid Boardgame to the Valid Creator's Boardgames
                    validCreator.Boardgames.Add(validBoardgame);
                }

                //Adding the Valid Creator to it's Collection
                validCreators.Add(validCreator);
                sb.AppendLine(String.Format(SuccessfullyImportedCreator, validCreator.FirstName, validCreator.LastName, validCreator.Boardgames.Count));
            }
            //Adding and Saving the Changes to the Database
            context.Creators.AddRange(validCreators);
            context.SaveChanges();

            //Output
            return sb.ToString().TrimEnd();
        }

        //Import JSON
        public static string ImportSellers(BoardgamesContext context, string jsonString)
        {
            //Deserializing the JSON to a Seller DTO
            ImportSellerDto[] sellerDtos = JsonConvert.DeserializeObject<ImportSellerDto[]>(jsonString);

            //Adding only the valid DTOs to the database
            HashSet<Seller> validSellers = new HashSet<Seller>();
            int[] boardgamesIds = context.Boardgames.Select(b => b.Id).ToArray();
            StringBuilder sb = new StringBuilder();

            //Seller
            foreach (var sellerDto in sellerDtos)
            {
                //Invalid Seller
                if (!IsValid(sellerDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                //Valid Seller
                Seller validSeller = new Seller()
                {
                    Name = sellerDto.Name,
                    Address = sellerDto.Address,
                    Country = sellerDto.Country,
                    Website = sellerDto.Website
                };

                //Boardgames
                foreach (var boardgameId in sellerDto.BoardgamesIds.Distinct())
                {
                    //Invalid BoardgameId
                    if (!boardgamesIds.Contains(boardgameId))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    //Valid BoardgameId
                    validSeller.BoardgamesSellers.Add(new BoardgameSeller()
                    {
                        SellerId = validSeller.Id,
                        BoardgameId = boardgameId
                    });
                }
                //Adding the Valid Seller to it's Collection
                validSellers.Add(validSeller);
                sb.AppendLine(String.Format(SuccessfullyImportedSeller, validSeller.Name, validSeller.BoardgamesSellers.Count));
            }
            //Adding and Saving the Changes to the Database
            context.Sellers.AddRange(validSellers);
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