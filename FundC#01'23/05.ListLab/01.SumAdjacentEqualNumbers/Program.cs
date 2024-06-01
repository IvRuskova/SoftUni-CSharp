
List<double> numbers = Console.ReadLine()
    .Split()
    .Select(double.Parse)
    .ToList(); // 3 3 6 1
for (int i = 0; i < numbers.Count-1; i++) // check indexs
{
    if (numbers[i] == numbers[i + 1]) 
    {
        numbers[i] += numbers[i + 1]; // add equal index
        numbers.RemoveAt(i+1); // remove second repided index
        i = -1; // go to the 0 index

    }
}
Console.WriteLine(string.Join(" ",numbers));

