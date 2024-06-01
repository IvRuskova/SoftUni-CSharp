using System;

namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int peopleCount = 0;

            double group1 = 0;
            double group2 = 0;
            double group3 = 0;
            double group4 = 0;
            double group5 = 0;

            for (int i = 1; i <= n; i++)
            {
                int group = int.Parse(Console.ReadLine());
                peopleCount += group;

                if (group <= 5)
                {
                    group1 += group;
                }
                else if (group <= 12)
                {
                    group2 += group;

                }
                else if (group <= 25)
                {
                    group3 += group;

                }
                else if (group <= 40)
                {
                    group4 += group;

                }
                else
                {
                    group5 += group;

                }
            }

            group1 = group1 / peopleCount * 100;
            group2 = group2 / peopleCount * 100;
            group3 = group3 / peopleCount * 100;
            group4 = group4 / peopleCount * 100;
            group5 = group5 / peopleCount * 100;


            Console.WriteLine($"{group1:F2}%");
            Console.WriteLine($"{group2:F2}%");
            Console.WriteLine($"{group3:F2}%");
            Console.WriteLine($"{group4:F2}%");
            Console.WriteLine($"{group5:F2}%");

        }
    }
}
