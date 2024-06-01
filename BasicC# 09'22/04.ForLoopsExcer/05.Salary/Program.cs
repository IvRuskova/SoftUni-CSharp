using System;

namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int openTab = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

           
            for (int i = 1; i <= openTab; i++)
            {
                string webName = Console.ReadLine();
                switch (webName)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }

            }
            if (salary>0)
            { 
                Console.WriteLine((int)salary);
            }

        }
    }
}
