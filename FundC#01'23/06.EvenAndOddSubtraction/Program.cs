//Input
int[] arrSum = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int sumEven = 0;
int sumOdd = 0;

//Act
for (int i = 0; i < arrSum.Length; i++)
{
    //Even
    if (arrSum[i] % 2 == 0)
    {
        sumEven += arrSum[i];
    }
    else
    {
        sumOdd += arrSum[i];
    }
}

//Output
Console.WriteLine(sumEven - sumOdd);