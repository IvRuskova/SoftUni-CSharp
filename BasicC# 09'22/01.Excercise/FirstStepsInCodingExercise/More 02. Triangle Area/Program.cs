using System;


namespace More_02.Triangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double triangleArea = (a * h) / 2;
            Console.WriteLine("{0:f2}", triangleArea);
        }
    }
}
