using System;

namespace PrepExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameMovie = Console.ReadLine();
            int days=int.Parse(Console.ReadLine()); 
            int numberTickets = int.Parse(Console.ReadLine());
            double priceTicket = double.Parse(Console.ReadLine());
            int procentCinema = int.Parse(Console.ReadLine());

            double priceTickets = numberTickets * priceTicket;
            double fullIncome = days * priceTickets;
            double procentLv = (procentCinema * 0.01) * fullIncome;
            double IncomeMovie = fullIncome - procentLv;    
            Console.WriteLine($"The profit from the movie {nameMovie} is {IncomeMovie:f2} lv."); 
        }
    }
}
