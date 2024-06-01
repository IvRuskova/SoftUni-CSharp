using System;

namespace Exer._08.OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hoursExamStart = int.Parse(Console.ReadLine());
            int minutesExamStart = int.Parse(Console.ReadLine());

            minutesExamStart = minutesExamStart+hoursExamStart*60;    

            int hoursArrival = int.Parse(Console.ReadLine());
            int minutesArrival = int.Parse(Console.ReadLine());

            minutesArrival = minutesArrival+hoursArrival*60;

            int diffrence = minutesExamStart - minutesArrival;

            // On time
            if (diffrence >= 0 && diffrence <= 30)
            {
                Console.WriteLine("On time");
                if (diffrence != 0)
                {
                    Console.WriteLine($"{diffrence} minutes before the start");
                }
            }
            // Earlier
            else if (diffrence > 30)
            {
                Console.WriteLine("Early");
                if (diffrence < 60)
                {
                    Console.WriteLine($"{diffrence} minutes before the start");
                }

                else
                {
                    int diffHours = diffrence / 60;
                    int diffMins = diffHours % 60;

                    Console.WriteLine($"{diffHours}:{diffMins:d2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("Late");

                diffrence = Math.Abs(diffrence);

                if (diffrence < 60)
                {
                    Console.WriteLine($"{diffrence} minutes after the start");
                }
                else
                {
                    int diffHours = diffrence / 60;
                    int diffMins = diffrence % 60;
                    Console.WriteLine($"{diffHours}:{diffMins:d2} hours after the start");
                }
            }
        }
        
    }
}
