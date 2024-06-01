using System;
using System.Diagnostics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double meter = double.Parse(Console.ReadLine());
            double yardGreen = meter * 7.61;
            double discount = 0.18 * yardGreen;
            double fullPrice = yardGreen - discount;
            Console.WriteLine($"The final price is: {fullPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
