﻿using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models.Cocktails
{
    public abstract class Cocktail : ICocktail
    {
        private string name;
        private string size;
        private double price;

        public Cocktail(string cocktailName, string size, double price)
        {
            cocktailName = Name;
            size = Size;
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
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new AggregateException(ExceptionMessages.NameNullOrWhitespace);
                }
                name = value;
            }
        }
        public string Size
        {
            get => size;
            private set => size = value;
        }

        public double Price
        {
            get => price;
            private set
            {
                if (Size == "Large")
                {
                    price = value;
                }
                else if(Size == "Middle")
                {
                    price = (value * 2) / 3;
                }
                else if (Size == "Small")
                {
                    price = value / 3;
                }
            }
        }
        public override string ToString()
        {
            
            return $"{Name} ({Size}) - {Price: f2} lv";
        }
    }
}
