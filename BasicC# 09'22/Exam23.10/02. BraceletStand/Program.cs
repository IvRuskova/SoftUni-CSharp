using System;

namespace _02._BraceletStand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double incomeMoneyFromSale = double.Parse(Console.ReadLine());
            double exprenceFullPeriod = double.Parse(Console.ReadLine());
            double priceGift = double.Parse(Console.ReadLine());
            
            int days = 5;

            money *=  days;
            incomeMoneyFromSale *= days;
            double fullSavedMoney = money + incomeMoneyFromSale;
            double endMoney = fullSavedMoney - exprenceFullPeriod;
            if (endMoney>priceGift)
            {
                Console.WriteLine($"Profit: {endMoney:f2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {priceGift-endMoney:f2} BGN.");
            }
            

        }
    }
}
