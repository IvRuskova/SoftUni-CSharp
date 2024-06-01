using System;

namespace  MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());   
            int markers = int.Parse(Console.ReadLine());
            int detergents = int.Parse(Console.ReadLine());
            int precent = int.Parse(Console.ReadLine());
            double fullPrice = (pens * 5.80) + (markers * 7.20) + (detergents * 1.20);
            double price = fullPrice - (fullPrice * (precent*0.01));
            Console.WriteLine(price);
        }
    }
}
