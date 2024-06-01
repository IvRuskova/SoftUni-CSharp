using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaОfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double area = 0;
            if (shape == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side*side;

            }
            else if (shape == "rectangle")
    {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;
    }
            else if (shape == "circle")
            {
                double pi = 3.14159;
                double radius=double.Parse(Console.ReadLine());
                area = Math.Round(pi * (radius * radius),3);  
            }
            else if (shape == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideHa = double.Parse(Console.ReadLine());

                area = (sideA * sideHa) / 2; 
            }
            Console.WriteLine(area);
        }
    }
}
