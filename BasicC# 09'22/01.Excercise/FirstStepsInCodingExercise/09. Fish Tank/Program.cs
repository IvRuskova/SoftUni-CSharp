using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double precent = double.Parse(Console.ReadLine());
            double volume = ((lenght*weight * height)*0.001)*(1-precent/100);
            Console.WriteLine(volume);
        }
    }
}
