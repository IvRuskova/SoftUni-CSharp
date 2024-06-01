using System;

namespace Exer._02._Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int degree = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            string outfit="";
            string shoes="";
            //Act
            //10 <= градуси <= 18
            if ( 10 <= degree && degree <= 18)
            {
                if (time == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (time == "Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (time == "Evening")                   
                {
                    
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            //18 < градуси <= 24
            else if (18 < degree && degree <= 24)
            {
                if (time == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (time == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (time == "Evening")
                {
                    
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            //градуси >= 25
            else if (degree >= 25)
            {
                if (time == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (time == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (time == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            //Output
            Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
        }
    }
}
