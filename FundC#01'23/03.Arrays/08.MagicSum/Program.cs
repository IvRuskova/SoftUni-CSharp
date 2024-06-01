int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int checkDigit = int.Parse(Console.ReadLine());
//int sumOfNumbers = 0;
//for (int i = 0; i < numbers.Length-1; i++)
//{
//    numbers[i] = sumOfNumbers; 
//    sumOfNumbers += numbers[i+1];
//   if(checkDigit == sumOfNumbers)
//    {
//        Console.WriteLine(numbers[i] +" " + numbers[i+1]);
//    }
//   sumOfNumbers = 0;
//}


for (int i = 0; i < numbers.Length - 1; i++)
{
    for (int k = i + 1; k < numbers.Length; k++)
    {
        if (numbers[i] + numbers[k] == checkDigit)
        {
            Console.Write(numbers[i] + " " + numbers[k]);
            Console.WriteLine();
            break;
        }
    }

}