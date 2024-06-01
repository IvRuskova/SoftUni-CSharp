using System;

namespace _05WhileLoopExerc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameBook=Console.ReadLine();
            
            int count=0;
            bool isBookFound = false;
            string anotherName = Console.ReadLine();
            while (anotherName != "No More Books")
            {
                if (anotherName == nameBook)
                {
                    isBookFound = true;
                    break;
                }
                count++;
                anotherName = Console.ReadLine();
  
            }
            if (isBookFound)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }

        }
    }
}
