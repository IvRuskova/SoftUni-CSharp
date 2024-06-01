using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories;
using ChristmasPastryShop.Repositories.Contracts;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models.Booths
{
    public class Booth : IBooth
    {
        private int boothId;
        private int capacity;
        private readonly IRepository<IDelicacy> delicacyMenu= new DelicacyRepository();
        private readonly IRepository<ICocktail> cocktailMenu = new CocktailRepository();
        private double currentBill;
        private double turnover;
        private bool isReserved;

        public Booth(int boothId, int capacity)
        {
            boothId = BoothId;
            capacity = Capacity;
            currentBill = 0;
            turnover = 0;
            isReserved = false;

        }
        public int BoothId { get => boothId; private set => boothId = value; }

        public int Capacity
        { 
            get => capacity;
            private set
            {
                if (value <=0)
                {
                    throw new AggregateException(ExceptionMessages.CapacityLessThanOne);
                }
                capacity = value;
            }
        }

        public IRepository<IDelicacy> DelicacyMenu => delicacyMenu;

        public IRepository<ICocktail> CocktailMenu => cocktailMenu;

        public double CurrentBill { get => currentBill; }

        public double Turnover { get => turnover;}

        public bool IsReserved { get => isReserved; }

        public void ChangeStatus()
        {
            //isReserved = !isReserved;
            if (isReserved = true)
            {
                isReserved = false;
            }
            isReserved = true;
        }

        public void Charge()
        {
            turnover += currentBill;
            currentBill = 0;
        }

        public void UpdateCurrentBill(double amount)
        {
            currentBill += amount;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Booth: {boothId}");
            sb.AppendLine($"Capacity: {capacity}");
            sb.AppendLine($"Turnover:{turnover:f2} lv");
            sb.AppendLine($"-Cocktail menu:");
            foreach (var cocktail in cocktailMenu.Models)
            {
                sb.AppendLine(cocktail.ToString());
            }
            sb.AppendLine("-Delicacy menu:");
            foreach (var delicacy in delicacyMenu.Models)
            {
                sb.AppendLine(delicacy.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
