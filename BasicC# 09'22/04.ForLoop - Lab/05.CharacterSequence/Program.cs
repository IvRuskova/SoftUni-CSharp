using System;

namespace _05.CharacterSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                //char letter = inpu[i];
                //Console.WriteLine(letter);
                Console.WriteLine(input[i]);
            }
        }
    }
}
