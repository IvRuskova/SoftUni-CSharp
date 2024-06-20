int[] inputNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int sum = 0;

for (int i = 0; i < inputNumbers.Length; i++)
{
    if (inputNumbers[i]%2 == 0)
    {
        sum += inputNumbers[i];
    }
}
Console.WriteLine(sum);
/* diffrent decision
 * 
 * int[] inputNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .Where(x => x % 2 == 0)
    .Sum();
  Conole.WriteLine(inputNumber);
 */