using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon =int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double fullPrice = ((nylon+2)*1.50)+((paint+(paint*0.1))*14.50)+(diluent*5)+0.4;
            double sum = ((fullPrice * 0.3) * hours)+ fullPrice;
            Console.WriteLine(sum);
        }
    }
}

