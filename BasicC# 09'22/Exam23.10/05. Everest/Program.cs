using System;

namespace _05._Everest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = 5364;
            int days = 1;
            while (true)
            {
                string command = Console.ReadLine();
                if (command =="END")
                {
                    break;
                }
                if (command =="Yes")
                {
                    days++;
                    if (days == 6)
                    {
                        break;
                    }
                }
                meters +=int.Parse(Console.ReadLine());
                if (meters >= 8848)
                {
                    break;
                }
            }
            if (meters>=8848)
            {
                Console.WriteLine($"Goal reached for {days} days!");
            }
            else
            {
                Console.WriteLine("Failed!");
                Console.WriteLine($"{meters}");
            }
        }
    }
}
