using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_15min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine()) ;
            int minutes = int.Parse(Console.ReadLine()) + 15;
           

            if (minutes > 59)
            {
                hours+=1;
                minutes -= 60;
            }
            else
            {
                minutes = minutes;
            }
            if (hours > 23)
            {
                hours -= 24;
            }
            else
            {
                hours = hours;
            }
            Console.WriteLine($"{hours}:{minutes:D2}");

        }
    }
}
