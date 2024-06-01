using System;

namespace _04._Workout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());

            double fullKm = m;

            for (int i = 0; i < n; i++)
            {
                double k = double.Parse(Console.ReadLine());
                m = m + m * (k / 100);
                fullKm += m;
            }
            if (fullKm >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(fullKm - 1000)} more   kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - fullKm)} more kilometers");
            }

        }
    }
}
