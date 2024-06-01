using System.Runtime.ExceptionServices;

namespace Methods
{
    internal class Program
    {
        /*
         * static void Main(string[] args)
        {
            PrintHelloWord();   
        }

        private static void PrintHelloWord()
        {
            Console.WriteLine("Hello Word");
        }
        */


        //static void Main(string[] args)
        //{
        //    PrintNumbers(5, 10);
        //}

        //static void PrintNumbers(int start, int end)
        //{
        //    for (int i = start; i <= end; i++)
        //    {
        //        Console.Write("{0}, ", i);
        //    }
        //}

        /*  1.Sign of Integer Number
        static void Main(string[] args)
        {
            PrintNumbers(int.Parse(Console.ReadLine()));
        }

        static void PrintNumbers(int n)
        {
            if (n>0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n<0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else
            {
                Console.WriteLine("The number 0 is zero. ");
            }
        }
        */

        /*  2. Print grade
        static void Main(string[] args)
        {
            ReceivesGrades(double.Parse(Console.ReadLine()));
        }

        static void ReceivesGrades(double grade)
        {
            if (grade>=2 && grade<=2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grade>=3.00 && grade<=3.49)
            {
                Console.WriteLine("Poor");
            }
            else if(grade>=3.50 && grade<=4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (grade >= 5.50 && grade<= 6.00)
            {
                Console.WriteLine("Excellent");
            }
            else
            {
                Console.WriteLine("Incorrect grade!");
            }
        }
        */

        /*  3.Calculation
        static void Main(string[] args)
        {
            string calculation=Console.ReadLine();
            int firstDigit=int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());
            switch (calculation)
            {
                case "add":
                    Add(firstDigit, secondDigit);
                    break;
                case "multiply":
                    Multiply(firstDigit, secondDigit);
                    break;
                case "subtract":
                    Subtract(firstDigit, secondDigit);
                    break;
                case "divide":
                    Divide(firstDigit, secondDigit);
                    break;
            }
        }
       static void Add(int firstDigit,int secondDigit)
        {
            int result = firstDigit + secondDigit;
            Console.WriteLine(result);
        }
        static void Multiply(int firstDigit, int secondDigit)
        {
            int result = firstDigit * secondDigit;
            Console.WriteLine(result);
        }
        static void Subtract(int firstDigit, int secondDigit)
        {
            int result = Math.Abs(firstDigit - secondDigit);
        }
        static void Divide(int firstDigit, int secondDigit)
        {
            int result = firstDigit / secondDigit;
            Console.WriteLine(result);
        }
        */

        /* 4. Printing Triangle
        static void Main(string[] args)
        {
            PrintingTriangle(int.Parse(Console.ReadLine()));
        }
        static void PrintingLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintingTriangle(int n)
        {
            for (int line = 1; line <= n; line++)
            {
                PrintingLine(1, line);
            }
            for (int line = n-1; line >= 1; line--)
            {
                PrintingLine(1, line);
            }
        }
        */

        /*  05.Orders
        static void Main(string[] args)
        {
            Price(Console.ReadLine(), int.Parse(Console.ReadLine()),0);


        }
        static void Price(string product, int quantity, double result)
        {
            if (product == "coffee")
            {
                result = quantity * 1.50;
            }
            else if (product == "water")
            {
                result = quantity * 1.00;
            }
            else if (product == "coke")
            {
                result = quantity * 1.40;
            }
            else if (product == "snacks")
            {
                result = quantity * 2.00;
            }
            Console.WriteLine($"{result:f2}");
        }
        */
    }
}