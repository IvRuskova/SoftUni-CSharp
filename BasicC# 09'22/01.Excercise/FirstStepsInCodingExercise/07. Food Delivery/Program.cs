using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickensMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegetablesMenu = int.Parse(Console.ReadLine());

            double fullPrice = (chickensMenu * 10.35) + (fishMenu * 12.40) + (vegetablesMenu * 8.15);
            double desertPrice = fullPrice * 0.20;
            fullPrice = fullPrice + desertPrice + 2.50;
            Console.WriteLine(fullPrice);


        }
    }
}
