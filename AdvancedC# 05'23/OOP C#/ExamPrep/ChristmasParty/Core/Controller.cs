using ChristmasPastryShop.Core.Contracts;
using ChristmasPastryShop.Models.Booths;
using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChristmasPastryShop.Core
{
    public class Controller : IController
    {
        private readonly BoothRepository booths = new BoothRepository();
        public string AddBooth(int capacity)
        {
           Booth booth = new Booth(booths.Models.Count+1, capacity);
           booths.AddModel(booth);
            return string.Format(OutputMessages.NewBoothAdded, booth.BoothId, capacity);
        }
        public string AddDelicacy(int boothId, string delicacyTypeName, string delicacyName)
        {
            if (delicacyTypeName != nameof(Gingerbread) && delicacyTypeName != nameof(Stolen))
            {
                return string.Format(OutputMessages.InvalidDelicacyType, delicacyTypeName);
            }
            if (this.booths.Models.Any(b=>b.DelicacyMenu.Models.Any(dm=>dm.Name == delicacyName)))
            {
                return string.Format(OutputMessages.DelicacyAlreadyAdded, delicacyName);
            }
            IDelicacy delicacy;
            if (delicacyTypeName == nameof(Gingerbread))
            {
                delicacy = new Gingerbread(delicacyName);
            }
            else
            {
                delicacy = new Stolen(delicacyName);
            }
            IBooth booth = this.booths.Models.FirstOrDefault(b=>b.BoothId ==  boothId);
            booth.DelicacyMenu.AddModel(delicacy);
            return string.Format(OutputMessages.NewDelicacyAdded, delicacyTypeName, delicacyName);
        }

        public string AddCocktail(int boothId, string cocktailTypeName, string cocktailName, string size)
        {
            if (cocktailTypeName != nameof(Hibernation) && cocktailName != nameof(MulledWine))
            {
                return string.Format(OutputMessages.InvalidCocktailType, cocktailTypeName);  
            }
            if (size != "Small"&& size != "Middle" && size != "Large")
            {
                return string.Format(OutputMessages.InvalidCocktailSize, size);
            }
            ICocktail cocktail;
            if (cocktailTypeName == nameof(Hibernation))
            {
                cocktail = new Hibernation(cocktailName, size);
            }
            else
            {
                cocktail = new MulledWine(cocktailName, size);

            }
            IBooth booth = this.booths.Models.FirstOrDefault(c => c.BoothId == boothId);
            booth.CocktailMenu.AddModel(cocktail);
            return string.Format(OutputMessages.NewCocktailAdded,size,cocktailName,cocktailTypeName);
        }

        public string ReserveBooth(int countOfPeople)
        {
            var searchedBooth = booths.Models
                .Where(b=>b.IsReserved== false&&b.Capacity >= countOfPeople)
                .OrderBy(b=>b.Capacity)
                .ThenByDescending(b=>b.BoothId)
                .FirstOrDefault();
            if (searchedBooth == null)
            {
                return string.Format(OutputMessages.NoAvailableBooth, countOfPeople);
            }
            searchedBooth.ChangeStatus();
            return string.Format(OutputMessages
                .BoothReservedSuccessfully,searchedBooth.BoothId, countOfPeople);
        }

        public string LeaveBooth(int boothId)
        {
            IBooth booth = this.booths.Models.FirstOrDefault(b => b.BoothId == boothId);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Bill {booth.CurrentBill:f2} lv");
            booth.Charge();
            booth.ChangeStatus();
            sb.AppendLine($"Booth {boothId} is now available!");
            return sb.ToString().TrimEnd();
        }


        public string TryOrder(int boothId, string order)
        {
            string[] orderInfo = order.Split("/", StringSplitOptions.RemoveEmptyEntries);
            string itemTypeName = orderInfo[0];
            string itemName = orderInfo[1];
            int orderedPiecesCount = int.Parse(orderInfo[2]);
            //Finding booth
            Booth currentBooth = (Booth)booths.Models.First(b => b.BoothId == boothId);
            //Finding Item
            //Cocktail
            if (itemTypeName == "Hibernation" || itemTypeName == "MulledWine")
            {
                string cocktailSize = orderInfo[3];
                if (!currentBooth.CocktailMenu.Models.Any(c=>c.Name == itemName))
                {
                    return string.Format(OutputMessages.NotRecognizedItemName, itemTypeName, itemName);
                }
                var desiredCocktail = currentBooth.CocktailMenu.Models.FirstOrDefault(c => c.GetType().Name == itemTypeName && c.Name == itemName && c.Size == cocktailSize);
                if (desiredCocktail == null)
                {
                    return String.Format(OutputMessages.CocktailStillNotAdded, cocktailSize, itemName);
                }
                currentBooth.UpdateCurrentBill(desiredCocktail.Price * orderedPiecesCount);
                return String.Format(OutputMessages.SuccessfullyOrdered, currentBooth.BoothId, orderedPiecesCount, itemName);
            }
            //Delicacy
            else if (itemTypeName == "Gingerbread" || itemTypeName == "Stolen")
            {
                if (!currentBooth.DelicacyMenu.Models.Any(c=>c.Name == itemName))
                {
                    return String.Format(OutputMessages.NotRecognizedItemName, itemTypeName, itemName);
                }
                var desiredDelicacy = currentBooth.DelicacyMenu.Models.FirstOrDefault(c => c.GetType().Name == itemTypeName && c.Name == itemName);
                if (desiredDelicacy is null)
                {
                    return String.Format(OutputMessages.DelicacyStillNotAdded, itemTypeName, itemName);
                }
                currentBooth.UpdateCurrentBill(desiredDelicacy.Price*orderedPiecesCount);
                return String.Format(OutputMessages.SuccessfullyOrdered, currentBooth.BoothId, orderedPiecesCount, itemName);
            }
            else
            {
                return String.Format(OutputMessages.NotRecognizedType, itemTypeName);
            }
        }
        public string BoothReport(int boothId)
        {
            Booth currBooth = (Booth)booths.Models.First(b => b.BoothId == boothId);
            return currBooth.ToString();
        }

    }
}
