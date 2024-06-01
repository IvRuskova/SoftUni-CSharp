using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double sm = 2.54;
            double toSm = number * sm;
            Console.WriteLine(toSm);
        }
    }
}
