
int n = int.Parse(Console.ReadLine());
//int tankC = 255;
int sum = 0;
while (n > 0)
{
    int liter=int.Parse(Console.ReadLine());
    
    if (sum + liter > 255)
	{
        Console.WriteLine("Insufficient capacity!");
    }
    else
    {
        sum += liter;
    }
    
    n--;
}
Console.WriteLine(sum);