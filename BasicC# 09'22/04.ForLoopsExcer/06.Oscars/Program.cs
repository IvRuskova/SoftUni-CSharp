using System;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());
            int joreys = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= joreys; i++)
            {
                string nameJourey = Console.ReadLine();
                double gradesJourey = double.Parse(Console.ReadLine());
      
                 grade = grade+(nameJourey.Length * gradesJourey/ 2);
                if (grade >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {grade:f1}!");
                    break;
                }
                
            }
            if (grade < 1250.5)
            {
                Console.WriteLine($"Sorry, {name} you need {1250.5-grade:f1} more!");
            }
        }
    }
}
