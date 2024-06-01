using System;

namespace Exer._05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destinacion="";
            double price = 0.0;
            string type = "";
            if (budget <=100)
            {
                destinacion = "Bulgaria";
                if (season == "summer")
                {
                    price = budget * 0.3;
                    type = "Camp";
                }
                else
                {
                    price = budget * 0.7;
                    type = "Hotel";
                }
            }
            else if (budget <=1000)
            {
                destinacion = "Balkans";
                if (season == "summer")
                {
                    price = budget * 0.4;
                    type = "Camp";
                }
                else
                {
                    price = budget * 0.8;
                    type = "Hotel";
                }
            }
            else
            {
                destinacion = "Europe";
                price = budget * 0.9;
                type = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destinacion}");
            Console.WriteLine($"{type} - {price:F2}");
        }
    }
}
