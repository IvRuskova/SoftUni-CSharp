﻿using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());
            double bill = (dogFood * 2.5) + (catFood * 4);
            Console.WriteLine($"{bill} lv");
        }
    }
}