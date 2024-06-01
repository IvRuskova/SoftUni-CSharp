using System;

namespace Exer._06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
             int n1 = int.Parse(Console.ReadLine());
             int n2 = int.Parse(Console.ReadLine());
             char symbol = char.Parse(Console.ReadLine());

            double sum = 0;

            //Act
            if (symbol == '+' || symbol=='-'|| symbol =='*')
            {
                string evenOrOdd = "";
                if (symbol == '+')
                {
                    sum = n1 + n2;
                }
                else if (symbol == '-')
                {
                    sum = n1 - n2;
                }
                else
                {
                    sum = n1 * n2;
                }
                if (sum %2 == 0)
                {
                    evenOrOdd = "even";
                    Console.WriteLine($"{n1} {symbol} {n2} = {sum} - {evenOrOdd}");
                }
                else
                {
                    evenOrOdd = "odd";
                    Console.WriteLine($"{n1} {symbol} {n2} = {sum} - {evenOrOdd}");
                }
                
            }
            else
            {
                if (symbol =='/' && n2 !=0)
                {
                    sum = (double)n1 / n2;
                    Console.WriteLine($"{n1} / {n2} = {sum:F2}" );
                }
                else if (symbol == '%' && n2 != 0)
                {
                    sum = n1 % n2;
                    Console.WriteLine($"{n1} % {n2} = {sum}");
                }
                else if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
            }

          
        }
    }
}
