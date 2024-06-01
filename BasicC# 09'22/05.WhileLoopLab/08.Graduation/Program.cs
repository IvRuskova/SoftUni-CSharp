using System;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int schoolClass = 1;
            double grades = 0;
            int outSchool=0;  
            

            while (schoolClass<=12)
            {
                double grade = double.Parse(Console.ReadLine());
                grades += grade;

                if (grade < 4.0)
                {
                    outSchool++;

                    if (outSchool>1)
                    {
                        Console.WriteLine($"{name} has been excluded at {schoolClass} grade");
                        return;
                    }
                    
                }
                else
                {
                    schoolClass++;
                }
               
            }
            double avrGrade = grades / (12 + outSchool);
            Console.WriteLine($"{name} graduated. Average grade: {avrGrade:f2}");
        }
    }
}
