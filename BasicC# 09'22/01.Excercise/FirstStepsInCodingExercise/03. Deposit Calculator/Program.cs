using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sumDeposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double sum = sumDeposit + months * (sumDeposit * (percent / 100) / 12);
            Console.WriteLine(sum);  
        }
    }
}