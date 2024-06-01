using System;

namespace _06._SumAndProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool isFound = false;
            for (int a = 0; a < 9; a++)
            {
                for (int b = 9; b > a; b--)
                {
                    for (int c = 0; c < 9; c++)
                    {
                        for (int d = 9; d > c; d--)
                        {
                            /*	Ако се намери валидна комбинация:
            	                "{number}", където {number} е комбинацията abcd или комбинацията dcba*/
                            if ((a+b+c+d)==a*b*c*d && n%10 == 5)
                            {
                                Console.WriteLine($"{a}{b}{c}{d}");
                                isFound = true; 
                            }
                            if (a * b * c * d/(a + b + c + d)==3 && n %3 ==0)
                            {
                                Console.WriteLine($"{d}{c}{b}{a}");
                                isFound = true;
                            }
                            if (isFound)
                            {
                                break;
                            }
                        }   
                    }
                }
                if (isFound)
                {
                    break;
                }

            }
            if (!isFound)
            {
                /*Ако НЕ се намери такава комбинация:
            	    "Nothing found"*/
                Console.WriteLine("Nothing found");
            }
        }
    }
}
