
	PrintSmallestNumber(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));


static void PrintSmallestNumber(int firstNumber,int secondNumber, int thirdNumber)
{
	if (firstNumber < secondNumber && firstNumber < thirdNumber)
	{
		Console.WriteLine(firstNumber);
	}
	else if (secondNumber < thirdNumber && secondNumber < firstNumber)
	{
		Console.WriteLine(secondNumber);
	}
	else if (thirdNumber < firstNumber && thirdNumber < secondNumber)
	{
		Console.WriteLine(thirdNumber);
	}
}