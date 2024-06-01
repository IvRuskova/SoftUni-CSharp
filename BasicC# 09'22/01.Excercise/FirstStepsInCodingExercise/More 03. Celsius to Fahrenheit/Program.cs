using System;


namespace More_03.Celsius_to_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03. Celsius to Fahrenheit (C * 1.8) + 32 = F
            double celsius = double.Parse(Console.ReadLine());
            double hahrenheit = (celsius * 1.8) + 32;
            Console.WriteLine("{0:f2}",hahrenheit);

        }
    }
}
