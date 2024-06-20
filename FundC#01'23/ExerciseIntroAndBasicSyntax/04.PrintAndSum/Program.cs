
int inputOne = int.Parse(Console.ReadLine());
int inputTwo = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = inputOne; i <= inputTwo; i++)
{
    Console.Write(i + " " );
    sum += i;
    
}
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");