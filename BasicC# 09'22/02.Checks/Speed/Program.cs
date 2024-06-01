using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double avrSpeed = double.Parse(Console.ReadLine());
            if (avrSpeed<=10)
            {
                Console.WriteLine("slow");
            }
            else if (avrSpeed <= 10)
            {
                Console.WriteLine("average");
            }
            else if (avrSpeed <= 50)
            {
                Console.WriteLine("average");
            }
            else if (avrSpeed > 50 && avrSpeed <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (avrSpeed > 150 && avrSpeed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else 
            {
                Console.WriteLine("extremely fast");
            }
            
        }
    }
}
