using System;

namespace _01._Excursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            int transportCards = int.Parse(Console.ReadLine());
            int ticketsMuse = int.Parse(Console.ReadLine());

            double priceNights = 20.0 * nights;
            double priceTransCard = 1.6 * transportCards;
            double priceTicketsMuseum = 6.0 * ticketsMuse;
            double price = (priceNights + priceTransCard + priceTicketsMuseum) * people;
            double procentPrice = price * 0.25;
            double fullPrice = price + procentPrice;
            Console.WriteLine($"{fullPrice:f2}");
        }
    }
}
