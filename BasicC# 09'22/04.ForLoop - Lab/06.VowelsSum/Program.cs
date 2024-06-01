using System;

namespace _06.VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string word = Console.ReadLine();
            int num = 0;
            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a':
                        num += 1;
                        break;
                    case 'o':
                        num += 4;
                        break;
                    case 'e':
                        num += 2;
                        break;
                    case 'i':
                        num += 3;
                        break;
                    case 'u':
                        num += 5;
                        break;
                }
            }
            Console.WriteLine(num);
        }
    }
}
