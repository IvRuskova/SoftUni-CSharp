//Input
List<int> priceRatings = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToList();
int entryPoint = int.Parse(Console.ReadLine());
string typeOfItems = Console.ReadLine(); 

//Act
int price = priceRatings[entryPoint];

int leftSum = 0;
int rightSum = 0;

if (typeOfItems == "cheap")
{
    for (int i = 0; i < entryPoint; i++)
    {
        if (priceRatings[i] < price)
        {
            leftSum += priceRatings[i];
        }
    }
    for (int i = entryPoint; i < priceRatings.Count; i++)
    {
        if (priceRatings[i] < price)
        {
            rightSum += priceRatings[i];
        }
    }
    //Output
    if (rightSum > leftSum)
    {
        Console.WriteLine($"Right - {rightSum}");
    }
    else if (leftSum >= rightSum)
    {
        Console.WriteLine($"Left - {leftSum}");
    }
}
else
{
    for (int i = 0; i < entryPoint; i++)
    {
        if (priceRatings[i]>=entryPoint)
        {
            leftSum += priceRatings[i];
        }
    }
    for (int i = entryPoint+1; i < priceRatings.Count; i++)
    {
        if (priceRatings[i] >= price)
        {
            rightSum += priceRatings[i];
        }
    }
    //Output
    if (leftSum < rightSum)
    {
        Console.WriteLine($"Right - {rightSum}");
    }
    else if (leftSum >= rightSum)
    {
        Console.WriteLine($"Left - {leftSum}");
    }
}
