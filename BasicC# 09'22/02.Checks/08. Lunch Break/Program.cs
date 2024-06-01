using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string tvShowName = Console.ReadLine();
            int tvShowTime = int.Parse(Console.ReadLine());
            int lunchTime = int.Parse(Console.ReadLine());

            double timeForTvShow = lunchTime * 5 / 8.0;

            if (tvShowTime<=timeForTvShow)
            {
                Console.WriteLine($"You have enough time to watch {tvShowName} and left with {Math.Ceiling(timeForTvShow-tvShowTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {tvShowName}, you need {Math.Ceiling(tvShowTime - timeForTvShow)} more minutes.");
            }

        }
    }
}
