using System;

namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            //Act
            if (city == "Sofia")
            {
                if (0 <= sales && sales <= 500)
                {
                    sales = sales *0.05;
                    Console.WriteLine($"{sales:F2}");
                }
                else if (500 < sales && sales <= 1000)
                {
                    sales = sales*0.07;
                    Console.WriteLine($"{sales:F2}");
                }
                else if (1000 < sales && sales <= 10000)
                {
                    sales = sales * 0.08;
                    Console.WriteLine($"{sales:F2}");
                }
                else if (sales> 10000)
                {
                    sales = sales * 0.12;
                    Console.WriteLine($"{sales:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Varna")
            {
                if (0 <= sales && sales <= 500)
                {
                    sales = sales * 0.045;
                    Console.WriteLine($"{sales:F2}");
                }
                else if (500 < sales && sales <= 1000)
                {
                    sales = sales * 0.075;
                    Console.WriteLine($"{sales:F2}");
                }
                else if (1000 < sales && sales <= 10000)
                {
                    sales = sales * 0.10;
                    Console.WriteLine($"{sales:F2}");
                }
                else if (sales > 10000)
                {
                    sales = sales * 0.13;
                    Console.WriteLine($"{sales:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Plovdiv")
            {
                if (0 <= sales && sales <= 500)
                {
                    sales = sales * 0.055;
                    Console.WriteLine($"{sales:F2}");
                }
                else if (500 < sales && sales <= 1000)
                {
                    sales = sales * 0.08;
                    Console.WriteLine($"{sales:F2}");
                }
                else if (1000 < sales && sales <= 10000)
                {
                    sales = sales * 0.12;
                    Console.WriteLine($"{sales:F2}");
                }
                else if (sales > 10000)
                {
                    sales = sales * 0.145;
                    Console.WriteLine($"{sales:F2}");
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
