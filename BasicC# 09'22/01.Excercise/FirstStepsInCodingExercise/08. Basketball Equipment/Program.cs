using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int priceCuirse = int.Parse(Console.ReadLine());
            double shoes = priceCuirse * 0.6;
            double sportCloths = shoes * 0.8;
            double balls = sportCloths * 0.25;
            double accessories = balls * 0.20;
            double price= priceCuirse+shoes+sportCloths+balls+accessories;
            Console.WriteLine(price);
        }
    }
}
