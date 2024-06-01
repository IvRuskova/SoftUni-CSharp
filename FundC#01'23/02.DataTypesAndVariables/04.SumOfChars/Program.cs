
int n = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i < n; i++)
{
    char cuccCh = char.Parse(Console.ReadLine());
    sum += (int)cuccCh;
}
Console.WriteLine($"The sum equals: {sum}");