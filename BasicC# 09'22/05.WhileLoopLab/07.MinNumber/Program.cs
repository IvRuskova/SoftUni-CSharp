using System;

namespace _07.MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int min = int.MaxValue;

            while (input != "Stop")
            {
                int num = int.Parse(input);
                if (min > num)
                {
                    min = num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(min);
        
        }
    }
}
