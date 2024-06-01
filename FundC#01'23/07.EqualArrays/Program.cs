//Input

int[] firstArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] secondArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

//Act
int sum = 0;
bool same = true;
for (int i = 0; i < firstArray.Length; i++)
{
    sum += firstArray[i];

    //Output
    //"Arrays are identical. Sum: {sum}"
    //"Arrays are not identical. Found difference at {index} index"
    if (firstArray[i] != secondArray[i])
    {
        Console.WriteLine($"Arrays are not identical.Found difference at {i} index");
        same = false;
        break;
    }
}
if (same)
{
    Console.WriteLine($"Arrays are identical. Sum: {sum}");
}
