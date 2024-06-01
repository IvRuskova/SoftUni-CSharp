using System;

namespace _04._Personal_Titles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            if (sex == 'f')
            {
                if (age >=16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
            else
            {
                if (age>=16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }
        }
    }
}
