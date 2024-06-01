using System;

namespace _02.FamilyHoliday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int procent = int.Parse(Console.ReadLine());

            double fullPriceNights;
            double left;
            if (nights > 7)
            {
                price = price - price* 0.05;
                fullPriceNights = price * nights;
                procent = budget * (procent/100.0);
                left = budget - fullPriceNights - procent;
                Console.WriteLine($"Ivanovi will be left with {left:f2} leva after vacation.");
            }
            else
            {
                fullPriceNights = (price * nights);
                procent = budget * (procent / 100.0);
                left = budget - fullPriceNights - procent;
                Console.WriteLine($"{Math.Abs(left):f2} leva needed.");
            }
            	
        }
    }
}
