List<int> numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

int[] specialBomb = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int bombNumber = specialBomb[0];
int bombPower = specialBomb[1];
int count = 0;

while (numbers.Contains(bombNumber))
{
    int bombIndex = numbers.FindIndex(x => x == bombNumber);
    int startIndex = bombIndex - bombPower;
    for (int i = startIndex; i < bombIndex; i++)
    {
        if (count>bombPower)
        {
            break;
        }
        if (startIndex<0)
        {
            startIndex = 0;
        }
        else if (i>numbers.Count-1)
        {
            break;
        }
        numbers.RemoveAt(i);
        i--;
        count++;
        bombIndex = numbers.FindIndex(x => x == bombNumber);
    }
    count = 0;
    bombIndex = numbers.FindIndex(x=>x==bombNumber);
    int endIndex = bombIndex + bombPower;
    if (endIndex>numbers.Count-1)
    {
        endIndex = numbers.Count - 1;
    }
    for (int i = bombIndex; i < endIndex; i++)
    {
        if (count > bombPower)
        {
            break;
        }
        if (bombIndex<0)
        {
            bombIndex = 0;
        }
        else if (i>numbers.Count-1)
        {
            break;
        }
        numbers.RemoveAt(i);
        i--;
        count++;
    }
    count = 0;
}
int sum = numbers.Sum();
Console.WriteLine(sum);
