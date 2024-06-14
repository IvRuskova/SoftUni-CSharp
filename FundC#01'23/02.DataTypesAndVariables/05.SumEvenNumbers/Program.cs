//Input
int[] arrSum = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int sum = 0;

//Act
for (int i = 0; i < arrSum.Length; i++)
{
    
    if (arrSum[i] % 2 == 0)
    {
        sum += arrSum[i];
    }
}

//Output
Console.WriteLine(sum);