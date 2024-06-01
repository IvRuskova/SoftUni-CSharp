using System;

namespace _03._ExcursionCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price=0;
            if (people <= 5)
            {
                if (season =="spring")
                {
                    price = people * 50;
                }
                else if (season == "summer")
                {
                    price = (people * 48.5)- ((people * 48.5)*0.15);
                }
                else if (season == "autumn")
                {
                    price = people * 60.0;
                }
                else if (season == "winter")
                {
                    price = (people * 86) + ((people * 86)*0.08);
                }
            }
            else
            {
                if (season == "spring")
                {
                    price = people * 48;
                }
                else if (season == "summer")
                {
                    price = (people * 45) - ((people * 45) * 0.15);
                }
                else if (season == "autumn")
                {
                    price = people * 49.5;
                }
                else if (season == "winter")
                {
                    price = (people * 85) + ((people * 85) * 0.08);
                }
            }

            Console.WriteLine($"{price:f2} leva.");
        }
    }
}
