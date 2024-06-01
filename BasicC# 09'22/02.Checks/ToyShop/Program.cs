using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double trip = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int tracks = int.Parse(Console.ReadLine());
            double sum = (puzzles * 2.60) + (dolls * 3.00) + (bears * 4.10) + (minions * 8.20) + (tracks * 2.00);
            int numToys = puzzles+dolls + bears + minions + tracks;
            double procentPrice;
            double price;
            double rent;
            double income;
            double balance;
            double needed;
            if (numToys >= 50)
            {
                procentPrice = sum * 0.25;
                price = sum - procentPrice;
                rent = price * 0.10;
                income = price - rent;
                balance = income - trip;
                Console.WriteLine($"Yes! {balance:F2} lv left.");    
                
            }
            else if(numToys <= 49)
            {
                price = sum;
                rent = price * 0.10;
                income = price - rent;
                needed = trip - income;
                Console.WriteLine($"Not enough money! {needed:F2} lv needed.");
            }
            /*using System;


            const double puzelPrice = 2.60;
            const double dolsPrice = 3;
            const double bearsPrice = 4.10;
            const double minionsPrice = 8.20;
            const double carsPrice = 2;

            double priceExcursie = double.Parse(Console.ReadLine());
            int puzelsCount = int.Parse(Console.ReadLine());
            int dolsCount = int.Parse(Console.ReadLine());
            int bearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int carsCount = int.Parse(Console.ReadLine());

            double totalPriceToys = (puzelsCount * puzelPrice) +
                                    (dolsCount * dolsPrice) +
                                    (bearsCount * bearsPrice) +
                                    (minionsCount * minionsPrice) +
                                    (carsCount * carsPrice);
            double totalCountToys = puzelsCount + dolsCount + bearsCount + minionsCount + carsCount;
            double discount = totalPriceToys * 0.25;
            double rent = 0;
            double restMoney = 0;

            if (totalCountToys >= 50)
            {
                totalPriceToys -= discount;
                rent = totalPriceToys * 0.10;
                restMoney = totalPriceToys - rent;
            }
            else
            {
                rent = totalPriceToys * 0.10;
                restMoney = totalPriceToys - rent;
            }
            double result = 0;
            if (restMoney >= priceExcursie)
            {
                result = restMoney - priceExcursie;
                Console.WriteLine($"Yes! {result:f2} lv left.");
            }
            else
            {
                result = priceExcursie - restMoney;
                Console.WriteLine($"Not enough money! {result:f2} lv needed.");
            }
     */

        }
    }
}
