using System;

namespace _07.WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Output
            int hours = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            //Act
            if (hours>=10 && hours <=18)
            {
                if (dayOfWeek=="Monday")
                {
                    Console.WriteLine("open");
                }
                else if (dayOfWeek == "Tuesday")
                {
                    Console.WriteLine("open");
                }
                else if (dayOfWeek == "Wednesday")
                {
                    Console.WriteLine("open");
                }
                else if (dayOfWeek== "Thursday")
                {
                    Console.WriteLine("open");
                }
                else if (dayOfWeek == "Friday")
                {
                    Console.WriteLine("open");
                }
                else if (dayOfWeek== "Saturday")
                {
                    Console.WriteLine("open");
                }
                else if (dayOfWeek == "Sunday")
                {
                    Console.WriteLine("closed");
                }
            }
            else 
            {
                Console.WriteLine("closed");
            }
           
            
        }
    }
}
