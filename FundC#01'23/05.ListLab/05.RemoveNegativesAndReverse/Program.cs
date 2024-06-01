
List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

numbers.RemoveAll(n => n < 0);
if (numbers.Count == 0 )
{
    Console.WriteLine("empty");
}
else
{
    Console.WriteLine(string.Join(" ", numbers));
}