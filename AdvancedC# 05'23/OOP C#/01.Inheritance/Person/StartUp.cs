using System;

namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            if (age>15)
            {
                Person person = new(age, name);
                Console.WriteLine(person);
            }
            else
            {
                Child child = new(age, name);
                Console.WriteLine(child);
            }
        }
    }

    
}