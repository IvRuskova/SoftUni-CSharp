// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());
decimal sum = 0m;
for (int i = 1; i<=n;i++)
{
   decimal digits = decimal.Parse(Console.ReadLine());

    sum += digits;
}
Console.WriteLine(sum);
