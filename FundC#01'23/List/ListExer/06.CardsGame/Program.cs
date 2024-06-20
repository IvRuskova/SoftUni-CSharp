
List<int> firstPlayer = Console.ReadLine()
    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
List<int> secondPlayer = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

while (true)
{
    for (int i = 0; i < firstPlayer.Count; i++)
    {
        if (secondPlayer.Sum() == 0)
        {
            Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            return;
        }
        if (firstPlayer.Sum() == 0)
        {
            Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            return;
        }
        if (firstPlayer[i] > secondPlayer[i])
        {
            firstPlayer.Add(secondPlayer[i]);
            firstPlayer.Add(firstPlayer[i]);
            firstPlayer[i] = 0;
            secondPlayer[i] = 0;
        }
        else if (firstPlayer[i] < secondPlayer[i])
        {
            secondPlayer.Add(firstPlayer[i]);
            secondPlayer.Add(secondPlayer[i]);
            firstPlayer[i] = 0;
            secondPlayer[i] = 0;
        }
        else
        {
            firstPlayer[i] = 0;
            secondPlayer[i] = 0;
        }
    }
}
