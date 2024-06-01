using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int RamMemories = int.Parse(Console.ReadLine());

            double videoCardPrice = videoCards * 250;
            double processorPrice = videoCardPrice * 0.35;
            double ramMemoryPrice = videoCardPrice * 0.10;

            double fullPrice = videoCardPrice +(processors*processorPrice)+(RamMemories*ramMemoryPrice);
            
           
            if  (videoCards > processors)
            {
                
                fullPrice = fullPrice-(0.15*fullPrice);
                
            }
            if(fullPrice <= buget)
            {
                Console.WriteLine($"You have {Math.Abs(fullPrice-buget):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(buget - fullPrice):f2} leva more!");
            }
        }
    }
}
