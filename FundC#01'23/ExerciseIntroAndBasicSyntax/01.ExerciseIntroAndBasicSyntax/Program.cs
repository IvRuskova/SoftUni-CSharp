using System;

namespace _01.ExerciseIntroAndBasicSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person=Console.ReadLine();
            var age = int.Parse(person);
            if (age<= 0 || age <=2)
            {
                Console.WriteLine("baby");
            }
            else if(age <= 3 || age <= 13)
            {
                Console.WriteLine("child");
            }
            else if (age <= 14 || age <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (age <= 20 || age <= 65)
            {
                Console.WriteLine("adult");
            }
            else if (age >= 66 )
            {
                Console.WriteLine("elder");
            }
        }
    }
}
