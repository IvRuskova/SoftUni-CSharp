int n =int.Parse(Console.ReadLine());

int[] firstArray = new int[n];
int[] secondArray = new int[n];

for (int i = 0; i < n; i++)
{
    int[] currInput = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    if (i % 2 == 0)
    {
        firstArray[i] = currInput[0];
        secondArray[i] = currInput[1];
    }
    else
    {
        secondArray[i] = currInput[0];
        firstArray[i] = currInput[1];
    }
}
Console.WriteLine(string.Join(" ",firstArray));
Console.WriteLine(string.Join(" ",secondArray));