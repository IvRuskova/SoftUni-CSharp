using System;

namespace _05.WhileLoopLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If you need to use continue operator, this construction is better and easier
            string text;
            while ((text = Console.ReadLine()) != "Stop")
            {
                Console.WriteLine(text);
            }
            
        }
    }
}
