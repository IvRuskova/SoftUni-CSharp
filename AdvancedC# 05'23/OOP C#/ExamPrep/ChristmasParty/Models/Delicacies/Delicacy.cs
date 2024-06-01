using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models.Delicacies
{
    public abstract class Delicacy : IDelicacy
    {
        private string name;
        private double price;
        public Delicacy(string delicacyName, double price)
        {
            delicacyName = Name;
            price = Price;
        }
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ExceptionMessages.NameNullOrWhitespace);
                }
                name = value;
            }
        }
        public double Price { get; private set;}
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            //"{delicacyName} - {current price - formatted to the second decimal place} lv"
            sb.AppendLine($"{Name} - {Price: f2} lv");
            return sb.ToString().TrimEnd();
        }
    }
}
