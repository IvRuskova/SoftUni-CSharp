
string input;
double totalCash = 0;
while ((input = Console.ReadLine()) != "Start")
{
    double coin = double.Parse(input);
    if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
    {
        totalCash += coin;
    }
    else
    {
        Console.WriteLine($"Cannot accept {coin}");
    }
}
double nutsPrice = 2.0;
double waterPrice = 0.7;
double crispsPrice = 1.5;
double sodaPrice = 0.8;
double cokePrice = 1.0;
string product;
while ((product = Console.ReadLine()) != "End")
{
    if (product == "Nuts")
    {
        if (nutsPrice <= totalCash)
        {
            Console.WriteLine($"Purchased nuts");
            totalCash -= nutsPrice;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }

    }
    else if (product == "Water")
    {
        if (waterPrice <= totalCash)
        {
            Console.WriteLine("Purchased water");
            totalCash -= waterPrice;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (product == "Crisps")
    {
        if (crispsPrice <= totalCash)
        {
            Console.WriteLine("Purchased crisps");
            totalCash -= crispsPrice;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (product == "Soda")
    {
        if (sodaPrice <= totalCash)
        {
            Console.WriteLine("Purchased soda");
            totalCash -= sodaPrice;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }

    }
    else if (product == "Coke")
    {
        if (cokePrice <= totalCash)
        {
            Console.WriteLine("Purchased coke");
            totalCash -= cokePrice;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }

    }
    else
    {
        Console.WriteLine("Invalid product");
    }

}
Console.WriteLine($"Change: {totalCash:f2}");