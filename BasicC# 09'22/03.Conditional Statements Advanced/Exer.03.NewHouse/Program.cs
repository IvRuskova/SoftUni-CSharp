using System;

namespace Exer._03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


                string flower = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());
                double budget = double.Parse(Console.ReadLine());

                double priceRoses = 5.0;
                double priceDahlias = 3.8;
                double priceTulips = 2.8;
                double priceNarcissus = 3.0;
                double priceGladiolus = 2.5;
                double priceFinal = 0.0;

                if (amount < 80)
                {
                    priceGladiolus = priceGladiolus * 1.2;
                }

                if (amount > 80)
                {
                    priceTulips = priceTulips * .85;
                    priceRoses = priceRoses * .9;
                }

                if (amount > 90)
                {
                    priceDahlias = priceDahlias * .85;
                }

                if (amount < 120)
                {
                    priceNarcissus = priceNarcissus * 1.15;
                }

                switch (flower)
                {
                    case "Roses":
                        priceFinal = priceRoses * amount; break;
                    case "Dahlias":
                        priceFinal = priceDahlias * amount; break;
                    case "Tulips":
                        priceFinal = priceTulips * amount; break;
                    case "Narcissus":
                        priceFinal = priceNarcissus * amount; break;
                    case "Gladiolus":
                        priceFinal = priceGladiolus * amount; break;
                    default:
                        break;
                }

                double difference = Math.Abs(budget - priceFinal);

                if (budget >= priceFinal)
                {
                    Console.WriteLine($"Hey, you have a great garden with {amount} {flower} and {difference:F2} leva left.");
                }
                else if (budget < priceFinal)
                {
                    Console.WriteLine($"Not enough money, you need {difference:F2} leva more.");
                }
            }
        }
    }


    ////Input
    //string typeFlowers = Console.ReadLine();
    //int numberFlowers = int.Parse(Console.ReadLine());  
    //int budget = int.Parse(Console.ReadLine());



    //double price = 0;
    //double leftSum = 0;


    ////Act
    //switch (typeFlowers)
    //{
    //    case "Roses":
    //        price = numberFlowers * 5;
    //        if (numberFlowers >= 80)
    //        {
    //            price = price - (price * 0.10);
    //        }
    //        break;
    //    case "Dahlias":
    //        price = numberFlowers * 3.80;
    //        if (numberFlowers >= 90)
    //        {
    //          price = price - (price * 0.15);
    //        }
    //        break;
    //    case "Tulips":
    //        price = numberFlowers * 2.80;
    //        if (numberFlowers >= 80)
    //        {
    //            price = price - (price * 0.15);
    //        }
    //        break;
    //    case "Narcissus":
    //        price = numberFlowers * 3;
    //           price = price + (price * 0.15);
    //        if (numberFlowers >= 120)
    //        {
    //            price = price + (price * 0.15);
    //        }
    //        break;
    //    case "Gladiolus":
    //        price = numberFlowers * 2.50;
    //        if (numberFlowers >= 80)
    //        {
    //            price = price + (price * 0.20);
    //        }
    //        break;

    //}
    ////Output

    ////Ако бюджета им е достатъчен - "Hey, you have a great garden with {numberFlowers} {typeFlowers} and {leftSum} leva left."

    ////Ако бюджета им е НЕ достатъчен - "Not enough money, you need {neededSum} leva more."

    //leftSum = Math.Abs(budget - price);
    //if (price < budget)
    //{
    //    Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {typeFlowers} and {leftSum:f2} leva left.");
    //}
    //else
    //{
    //    Console.WriteLine($"Not enough money, you need {leftSum:f2} leva more.");
    //}

