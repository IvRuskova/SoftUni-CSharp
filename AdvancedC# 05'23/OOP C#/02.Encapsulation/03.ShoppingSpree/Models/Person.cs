﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShoppingSpree.Models
{
    public class Person
    {
        // name, money and bag of products 
        private string name;
        private decimal money;
        private List<Product> bagOfProducts;
            public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bagOfProducts = new List<Product>();
        }
        public string Name { 
            get=> name;
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameExceptionMessage);
                
            }
                name = value;
            } 
        }
        public decimal Money 
        { get => money;
            set {
                if (value<0)
                {
                    throw new ArgumentException(ExceptionMessages.MoneyExceptionMessage);
                }
                money = value;
            } }
        public string Add(Product product)
        {
            if (Money < product.Cost)
            {
                return $"{Name} can't afford {product}";
            }
            bagOfProducts.Add(product);
            Money -= product.Cost;
            return $"{Name} bought {product}";
        }

            public override string ToString()
        {
            string products = bagOfProducts.Any() ? string.Join(", ", bagOfProducts) : "Nothing bought";
            return $"{Name} - {products}";
        }
    }
}
