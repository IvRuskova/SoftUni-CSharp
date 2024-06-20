using System;

namespace _04.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = startNumber; i < endNumber; i++)
            {
                for (int j = endNumber; j > startNumber; j++)
                {
                    if((startNumber + endNumber) == magicNumber)
                    {
                        count++;

                    }
                } 
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})",count,startNumber,endNumber,magicNumber);
            }

            if (count == 0)
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
            }
        }
    }
}