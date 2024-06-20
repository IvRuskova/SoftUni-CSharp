int n = int.Parse(Console.ReadLine());
int[] number = new int[n];

for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    number[i] = currentNumber;
}
for (int i = number.Length - 1; i >= 0; i--)
{
    Console.Write(number[i]+ " ");
}
/* diffrent decision
 * int[] reverseNumbers = numbers.Reverse().ToArray(); //
 * 
 * for(int i =0; i<numbers.Length /2; i++){
 *  int firstNumber = numbers[i];
 *  int lastNumber = number[numbers.Length -1 - i];
 *  numbers[i] = lastNumber;
 *  numbers[numbers.Length - 1 - i] = firstNumber;
 * }
 * 
 */