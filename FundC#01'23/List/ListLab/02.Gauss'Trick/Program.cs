List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList(); //1 2 3 4 5
int originalLength = numbers.Count; // euals to numberes
           //originalLength / 2 taked half element of the list
for (int i = 0; i < originalLength / 2; i++)
{
    numbers[i] += numbers[numbers.Count-1]; // first element + last element
    numbers.RemoveAt(numbers.Count-1); // remove last element
}
Console.WriteLine(string.Join(" ", numbers));