//Input
double[] numbers = Console.ReadLine()
    .Split()
    .Select(double.Parse)
    .ToArray();

//Act
for (int i = 0; i < numbers.Length; i++)
{
    //Output
    Console.WriteLine($"{numbers[i]} => {Math.Round(numbers[i],MidpointRounding.ToZero)}");
    
}

    
