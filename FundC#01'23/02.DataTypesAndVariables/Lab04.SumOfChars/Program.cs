int n = int.Parse(Console.ReadLine());
int totalSum = 0;
while (n !=0)
{
    char latter = char.Parse(Console.ReadLine());
    totalSum += (int)latter;
    n--;
}
Console.WriteLine($"The sum equals: {totalSum}");