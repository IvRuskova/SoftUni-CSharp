int[] inputNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int evenSum = 0;
int oddSum = 0;

foreach (var currNumber in inputNumbers)
{
    if (currNumber % 2 == 0)
    {
        evenSum += currNumber;
    }
    else
    {
        oddSum += currNumber;
    }
}
Console.WriteLine(evenSum - oddSum);
