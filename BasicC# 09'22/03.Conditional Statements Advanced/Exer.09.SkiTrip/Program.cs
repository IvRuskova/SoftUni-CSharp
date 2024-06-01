using System;

namespace Exer._09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string place = Console.ReadLine();
            string rate = Console.ReadLine();

            double price = 0.0;

            if (place == "room for one person")
            {
                price = 18 * (days - 1);
            }
            else if (place == "apartment")
            {
                price = 25 * (days - 1);

                if (days > 15)
                {
                    price *= 0.50;
                }
                else if (days > 9)
                {
                    price *= 0.65;
                }
                else
                {
                    price *= 0.70;
                }
            }
            else
            {
                price = (35 * (days - 1));

                if (days > 15)
                {
                    price *= 0.80;
                }
                else if (days > 9)
                {
                    price *= 0.85;
                }
                else
                {
                    price *= 0.90;
                }
            }

            if (rate == "positive")
            {
                price *= 1.25;
            }
            else
            {
                price *= 0.9;
            }
            Console.WriteLine($"{price:F2}");
        }
    }
}
