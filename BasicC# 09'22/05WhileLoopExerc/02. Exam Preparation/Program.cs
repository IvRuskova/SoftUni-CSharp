using System;
using System.Drawing;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGrade = int.Parse(Console.ReadLine());

            double avrGrade = 0;
            int countBadGrade = 0;
            int countGoodExer = 0;
            string lastExer = string.Empty;
            bool isFail = true;
            while (badGrade > countBadGrade)
            {
                string nameExer = Console.ReadLine();

                if (nameExer == "Enough")
                {
                    isFail = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    countBadGrade++;

                }
                avrGrade += grade;
                countGoodExer++;
                lastExer = nameExer;
            }
                if (isFail)
                {

                    Console.WriteLine($"You need a break, {countBadGrade} poor grades.");
                }

                else
                {
                    Console.WriteLine($"Average score: {avrGrade / countGoodExer:f2}");
                    Console.WriteLine($"Number of problems: {countGoodExer}");
                    Console.WriteLine($"Last problem: {lastExer}");
                }

            


        }
    }
}

