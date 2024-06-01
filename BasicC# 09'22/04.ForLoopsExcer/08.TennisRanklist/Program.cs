using System;
using System.Threading;

namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberTur = int.Parse(Console.ReadLine());
           double startPoints = double.Parse(Console.ReadLine());
            string typeTur=string.Empty;

            double finalPoint = 0;
            int count = 0;
            for (int i = 0; i <= numberTur; i++)
            {

                typeTur = Console.ReadLine();

                if (typeTur == "W")
                {
                    finalPoint += 2000;
                    count += 1;

                }
                else if (typeTur == "F")
                {
                    finalPoint += 1200;
                }
                else if (typeTur == "SF")
                {
                    finalPoint += 720;
                }
            }
            
            double avgPoint = (double)finalPoint/numberTur;
            double proWin =  ((double)count/ numberTur) * 100; 
                                                                                       
            Console.WriteLine($"Final points: {finalPoint+startPoints}");
            Console.WriteLine($"Average points: {Math.Floor(avgPoint)}");
            Console.WriteLine($"{proWin:f2}%");
            
        }   
    }
}
