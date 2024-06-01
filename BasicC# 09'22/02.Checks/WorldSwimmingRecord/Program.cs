using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double secondRecord = double.Parse(Console.ReadLine());
            double distanceMeter = double.Parse(Console.ReadLine());
            double timeSeconds = double.Parse((Console.ReadLine()));
            double tdelay = Math.Floor(distanceMeter / 15);
            double fullTime =  tdelay * 12.50 + (distanceMeter * timeSeconds);
            double notRecords =  fullTime - secondRecord;
            if (secondRecord>fullTime)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", fullTime);
            }
            else
            {
                Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", notRecords);
            }
        }
    }
}
