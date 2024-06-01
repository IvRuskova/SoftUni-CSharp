using System;

namespace Exer._01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string type = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            //Act
            double income = 0;
            if (type == "Premiere")
            {
                income = row * colums * 12.00;

            }
            else if (type == "Normal")
            {
                income = row * colums * 7.50;
            }
            else if (type == "Discount")
            {
                income = row * colums * 5.00;
            }
            //Output
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
