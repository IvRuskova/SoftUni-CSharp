int[] inputNumber = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int rotation = int.Parse(Console.ReadLine());

for (int i = 0; i < rotation; i++)
{
    int firstElement = inputNumber[0];
    for (int j = 0; j < inputNumber.Length - 1; j++)
    {
        inputNumber[j] = inputNumber[j + 1];
    }
    inputNumber[inputNumber.Length - 1] = firstElement;
}
Console.WriteLine(String.Join(" ",inputNumber));