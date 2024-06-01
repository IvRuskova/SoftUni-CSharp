using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int numberPage = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int numberHours = (pages/numberPage)/days;
            Console.WriteLine(numberHours);
        }
    }
}
