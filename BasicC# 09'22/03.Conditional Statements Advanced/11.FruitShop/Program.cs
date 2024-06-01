﻿using System;

namespace _11.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            //Act
            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek== "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek== "Friday" )
            {
                if (fruit == "banana")
                {
                    price = 2.50;
                    double bills = price * quantity;
                    Console.WriteLine($"{bills:F2}");
                }
                else if (fruit == "apple")
                {
                    price = 1.20;
                    double bills = price * quantity;
                    Console.WriteLine($"{bills:F2}");
                }
                else if (fruit =="orange")
                {
                    price = 0.85;
                    double bills = price * quantity;
                    Console.WriteLine($"{bills:F2}");
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.45;
                    double bills = price * quantity;
                    Console.WriteLine($"{bills:F2}");
                }
                else if (fruit== "kiwi")
                {
                    price = 2.70;
                    double bills = price * quantity;
                    Console.WriteLine($"{bills:F2}");
                }
                else if (fruit == "pineapple")
                {
                    price = 5.50;
                    double bills = price * quantity;
                    Console.WriteLine($"{bills:F2}");
                }
                else if (fruit == "grapes")
                {
                    price = 3.85;
                    double bills = price * quantity;
                    Console.WriteLine($"{bills:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (dayOfWeek == "Saturday" || dayOfWeek =="Sunday")
            {
                if (fruit == "banana")
                {
                    price = 2.70;
                    double bills = price * quantity;
                    Console.WriteLine($"{bills:F2}");
                }
                else if (fruit == "apple")
                {
                    price = 1.25;
                    double bills = price * quantity;
                    Console.WriteLine($"{bills:F2}");
                }
                else if (fruit == "orange")
                {
                    price = 0.90;
                    double bills = price * quantity;
                    Console.WriteLine($"{bills:F2}");
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.60;
                    double bills = price * quantity;
                    Console.WriteLine($"{bills:F2}");
                }
                else if (fruit == "kiwi")
                {
                    price = 3.00;
                    double bills = price * quantity;
                    Console.WriteLine($"{bills:F2}");
                }
                else if (fruit == "pineapple")
                {
                    price = 5.60;
                    double bills = price * quantity;
                    Console.WriteLine($"{bills:F2}");

                }
                else if (fruit == "grapes")
                {
                    price = 4.20;
                    double bills = price * quantity;
                    Console.WriteLine($"{bills:F2}");

                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
          
            
            
            
        }
    }
}
