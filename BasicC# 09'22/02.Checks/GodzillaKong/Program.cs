using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodzillaKong
{
    internal class Program
    {
        static void Main(string[] args)
        { 
        //{
        //    double buget = double.Parse(Console.ReadLine());
        //    int person = int.Parse(Console.ReadLine());
        //    double price = double.Parse(Console.ReadLine());
        //    double decor = buget * 0.10;
        //    price *= person;
        //    double fullMoviePrice = decor + price;
        //    double balance = buget - fullMoviePrice;
        //    if (decor > buget && price > buget)
        //    {

        //        Console.WriteLine("Not enough money!");
        //        Console.WriteLine($"Wingard needs {balance:f2} leva more.");
        //    }
        //    else if(person > 149)
        //    {
        //        price *= 0.10;
        //        Console.WriteLine("Not enough money!");
        //        Console.WriteLine($"Wingard needs {balance:f2} leva more.");

        //    }
        //    else
        //    {
        //        Console.WriteLine("Action!");
        //        Console.WriteLine($"Wingard starts filming with {balance:f2} leva left.");
        //    }

        double buget = double.Parse(Console.ReadLine());
        int persons = int.Parse(Console.ReadLine());
        double clothesPrice = double.Parse(Console.ReadLine());

        double decor = buget * 0.1;
        double clothesPriceTotal = 0;
 
            if (persons>150)
            {
                clothesPriceTotal = persons* clothesPrice * 0.9;
            }
            else 
            { 
                clothesPriceTotal = clothesPrice* persons;
            }
            if (buget < decor + clothesPriceTotal)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(decor + clothesPriceTotal - buget):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(buget - (decor + clothesPriceTotal)):f2} leva left.");
            }
        }
    }
}
