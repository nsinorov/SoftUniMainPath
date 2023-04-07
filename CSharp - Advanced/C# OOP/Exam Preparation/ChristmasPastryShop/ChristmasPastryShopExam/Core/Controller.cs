using ChristmasPastryShop.Core.Contracts;
using ChristmasPastryShop.Models.Booths;
using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories;
using ChristmasPastryShop.Repositories.Contracts;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChristmasPastryShop.Core
{
    public class Controller : IController
    {
        private IRepository<IBooth> booths;

        public Controller()
        {
            booths = new BoothRepository();
        }
        public string AddBooth(int capacity)
        {
            IBooth booth = new Booth(booths.Models.Count + 1, capacity);
            booths.AddModel(booth);
            return string.Format(OutputMessages.NewBoothAdded, booth.BoothId, capacity);
        }

        public string AddCocktail(int boothId, string cocktailTypeName, string cocktailName, string size)
        {
            if (cocktailTypeName != "Hibernation" && cocktailTypeName != "MulledWine")
            {
                return string.Format(OutputMessages.InvalidCocktailType, cocktailTypeName);
            }
            if (size != "Small" && size != "Middle" && size != "Large")
            {
                return string.Format(OutputMessages.InvalidCocktailSize, size);
            }
            if (booths.Models.Any(x => x.CocktailMenu.Models.Any(x => x.Name == cocktailName && x.Size == size)))
            {
                return string.Format(OutputMessages.CocktailAlreadyAdded, size, cocktailName);
            }
            ICocktail cocktail;
            if (cocktailTypeName == "Hibernation")
            {
                cocktail = new Hibernation(cocktailName, size);

            }
            else
            {
                cocktail = new MulledWine(cocktailName, size);
            }

            IBooth booth = booths.Models.FirstOrDefault(x => x.BoothId == boothId);
            booth.CocktailMenu.AddModel(cocktail);
            return string.Format(OutputMessages.NewCocktailAdded, size, cocktailName, cocktailTypeName);
        }

        public string AddDelicacy(int boothId, string delicacyTypeName, string delicacyName)
        {
            IDelicacy delicacy;
            IBooth booth = booths.Models.FirstOrDefault(b => b.BoothId == boothId);

            if (delicacyTypeName == "Gingerbread")
            {
                delicacy = new Gingerbread(delicacyName);
            }
            else if (delicacyTypeName == "Stolen")
            {
                delicacy = new Stolen(delicacyName);
            }
            else
            {
                return string.Format(OutputMessages.InvalidDelicacyType, delicacyTypeName);
            }

            if (booth.DelicacyMenu.Models.Any(d => d.Name == delicacyName))
            {
                return string.Format(OutputMessages.DelicacyAlreadyAdded, delicacyName);
            }

            booth.DelicacyMenu.AddModel(delicacy);

            return string.Format(OutputMessages.NewDelicacyAdded, delicacyTypeName, delicacyName);
        }

        public string BoothReport(int boothId)
        {
            return this.booths.Models.FirstOrDefault(b => b.BoothId == boothId).ToString().TrimEnd();
        }

        public string LeaveBooth(int boothId)
        {
            IBooth booth = booths.Models.FirstOrDefault(x => x.BoothId == boothId);
            booth.Charge();
            booth.ChangeStatus();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Bill {booth.Turnover:f2} lv");
            sb.AppendLine($"Booth {boothId} is now available!");
            return sb.ToString().TrimEnd();
        }

        public string ReserveBooth(int countOfPeople)
        {
            List<IBooth> boothsList = booths.Models.Where(b => b.IsReserved == false && b.Capacity >= countOfPeople)
               .OrderBy(b => b.Capacity).ThenByDescending(b => b.BoothId).ToList();

            IBooth firstAvailableBooth = boothsList.FirstOrDefault();

            if (firstAvailableBooth == null)
            {
                return string.Format(OutputMessages.NoAvailableBooth, countOfPeople);
            }

            firstAvailableBooth.ChangeStatus();

            return string.Format(OutputMessages.BoothReservedSuccessfully, firstAvailableBooth.BoothId, countOfPeople);
        }

        public string TryOrder(int boothId, string order)
        {
            string[] orderTokens = order.Split("/");
            string itemTypeName = orderTokens[0];
            string itemName = orderTokens[1];
            int count = int.Parse(orderTokens[2]);
            string size;

            IBooth booth = booths.Models.FirstOrDefault(b => b.BoothId == boothId);

            if (itemTypeName == "Hibernation")
            {
                size = orderTokens[3];

                ICocktail cocktail = booth.CocktailMenu.Models.FirstOrDefault(c => c.Name == itemName && c.GetType().Name == itemTypeName);

                if (!booth.CocktailMenu.Models.Any(i => i.Name == itemName))
                {
                    return string.Format(OutputMessages.NotRecognizedItemName, itemTypeName, itemName);
                }

                if (!booth.CocktailMenu.Models.Any(i => i.Name == itemName && i.Size == size && cocktail.GetType().Name == itemTypeName))
                {
                    return string.Format(OutputMessages.NotRecognizedItemName, size, itemName);
                }


                booth.UpdateCurrentBill(cocktail.Price * count);

                return string.Format(OutputMessages.SuccessfullyOrdered, boothId, count, itemName);
            }
            else if (itemTypeName == "MulledWine")
            {
                size = orderTokens[3];

                ICocktail cocktail = booth.CocktailMenu.Models.FirstOrDefault(c => c.Name == itemName && c.GetType().Name == itemTypeName);

                if (!booth.CocktailMenu.Models.Any(i => i.Name == itemName))
                {
                    return string.Format(OutputMessages.NotRecognizedItemName, itemTypeName, itemName);
                }

                if (!booth.CocktailMenu.Models.Any(i => i.Name == itemName && i.Size == size && cocktail.GetType().Name == itemTypeName))
                {
                    return string.Format(OutputMessages.NotRecognizedItemName, size, itemName);
                }


                booth.UpdateCurrentBill(cocktail.Price * count);

                return string.Format(OutputMessages.SuccessfullyOrdered, boothId, count, itemName);

            }
            else if (itemTypeName == "Gingerbread")
            {

                if (!booth.DelicacyMenu.Models.Any(i => i.Name == itemName))
                {
                    return string.Format(OutputMessages.NotRecognizedItemName, itemTypeName, itemName);
                }

                if (!booth.DelicacyMenu.Models.Any(i => i.Name == itemName && i.GetType().Name == itemTypeName))
                {
                    return string.Format(OutputMessages.NotRecognizedItemName, itemTypeName, itemName);
                }

                IDelicacy delicacy = booth.DelicacyMenu.Models.FirstOrDefault(d => d.Name == itemName && d.GetType().Name == itemTypeName);

                booth.UpdateCurrentBill(delicacy.Price * count);

                return string.Format(OutputMessages.SuccessfullyOrdered, boothId, count, itemName);

            }
            else if (itemTypeName == "Stolen")
            {

                if (!booth.DelicacyMenu.Models.Any(i => i.Name == itemName))
                {
                    return string.Format(OutputMessages.NotRecognizedItemName, itemTypeName, itemName);
                }

                if (!booth.DelicacyMenu.Models.Any(i => i.Name == itemName && i.GetType().Name == itemTypeName))
                {
                    return string.Format(OutputMessages.NotRecognizedItemName, itemTypeName, itemName);
                }

                IDelicacy delicacy = booth.DelicacyMenu.Models.FirstOrDefault(d => d.Name == itemName && d.GetType().Name == itemTypeName);

                booth.UpdateCurrentBill(delicacy.Price * count);

                return string.Format(OutputMessages.SuccessfullyOrdered, boothId, count, itemName);


            }
            else
            {
                return string.Format(OutputMessages.NotRecognizedType, itemTypeName);
            }
        }
    }
}

