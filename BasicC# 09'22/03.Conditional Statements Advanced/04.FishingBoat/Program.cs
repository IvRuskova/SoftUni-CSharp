using System;

namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine()); 
            string season = Console.ReadLine(); 
            int fishmen = int.Parse(Console.ReadLine());

            double priceBoat = 0;
            switch (season)
            {
                case "Spring":
                    priceBoat = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    priceBoat = 4200;
                    break;
                case "Winter":
                    priceBoat = 2600;
                    break;              
            }
            if (fishmen<=6)
            {
                priceBoat = priceBoat - (priceBoat * 0.1);
            }
            else if (fishmen <=11)
            {
                priceBoat = priceBoat - (priceBoat * 0.15);
            }
            else 
            {
                priceBoat = priceBoat - (priceBoat * 0.25);
            }
            if (fishmen%2==0 && season!= "Autumn")
            {
                priceBoat = priceBoat - (priceBoat * 0.05);
            }
            double diffrence = Math.Abs(budget - priceBoat);
            if (budget >= priceBoat)
            {
                Console.WriteLine($"Yes! You have {diffrence:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {diffrence:F2} leva.");
            }
        }
    }
}
