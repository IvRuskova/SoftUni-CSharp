
List<int> sequenseNumber = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
int[] specialBombNumber = Console.ReadLine()
    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int bomb = specialBombNumber[0];
int power = specialBombNumber[1];
int indexBomb = 0;

while (sequenseNumber.Contains(bomb))
{
    for (int i = 0; i < sequenseNumber.Count; i++)
    {
        if (sequenseNumber[i] == bomb)
        {
            indexBomb = i;
            break;
        }
    }

    int startIndex = indexBomb - power;
    int count = (2 * power) + 1;
    if (startIndex < 0)
    {
        startIndex = 0;
    }
    if (count > sequenseNumber.Count - 1)
    {
        count = sequenseNumber.Count - startIndex;
    }
    sequenseNumber.RemoveRange(startIndex, count);
}
Console.WriteLine(sequenseNumber.Sum());