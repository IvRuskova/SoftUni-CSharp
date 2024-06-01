using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());    
            double priceWashingMachine = double.Parse(Console.ReadLine());
            double priceToy = double.Parse(Console.ReadLine());

            double money = 0;
           
            //брой четни години
            int numEven = age / 2;
            int sumEven = 0;
            for (int i = 1; i <= numEven; i++)
            {
                sumEven += i;
                money = sumEven * 10.00 - numEven * 1.00 + (numEven + age % 2) * priceToy;
            }
            if (money>=priceWashingMachine)
            {
                Console.WriteLine($"Yes! {money- priceWashingMachine:f2}");
            }
            else 
            {
                Console.WriteLine($"No! {priceWashingMachine - money:f2}");
            }
            

        }
    }
}
