using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numberProject=int.Parse(Console.ReadLine());
            int hoursPerProjects = numberProject * 3;
            Console.WriteLine($"The architect {name} will need {hoursPerProjects} hours to complete {numberProject} project/s.");

        }
    }
}

