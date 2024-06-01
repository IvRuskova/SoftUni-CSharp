using System;

namespace _06.NestedLoopsExer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count=1;
           
            bool isBigger = false;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (count>n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write($"{count} ");
                    count++;
                }
                
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
