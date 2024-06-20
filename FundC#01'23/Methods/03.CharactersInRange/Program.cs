char first = char.Parse(Console.ReadLine());
char second = char.Parse(Console.ReadLine());

if (first>second)
{
    char rev = first;
    first = second;
    second = rev;
}
for (int i = first+1; i < second; i++)
{
    Console.WriteLine($"{(char)i} ");
}
