using System;

namespace _08.NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int minValue = int.MaxValue;
            int maxValue = int.MinValue;    
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (minValue > number )
                {
                    minValue = number;
                }
                if (maxValue < number)
                {
                    maxValue = number;
                }
            }
            Console.WriteLine($"Max number:{maxValue}");
            Console.WriteLine($"Min number:{minValue}");

        }
    }
}
