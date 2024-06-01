
List<int> firstPayer = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
List<int> secondPayer = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
while (true)
{
    if (firstPayer[0] > secondPayer[0])
    {
        firstPayer.Add(firstPayer[0]);
        firstPayer.Add(secondPayer[0]);
    }
    else if (firstPayer[0] < secondPayer[0])
    {
        secondPayer.Add(secondPayer[0]);
        secondPayer.Add(firstPayer[0]);
    }
    firstPayer.Remove(firstPayer[0]);
    secondPayer.Remove(secondPayer[0]);
    if (firstPayer.Count == 0 )
    {
        int sum = secondPayer.Sum();
        Console.WriteLine($"Second player wins! Sum:{sum}");
        break;
    }
    else if (secondPayer.Count == 0)
    {
        int sum = firstPayer.Sum();
        Console.WriteLine($"First player wins! Sum:{sum}");
        break;
    }
}