
List<string> array=Console.ReadLine()
    .Split('|')
    .ToList();
List<string> input =new List<string>();

for (int i = array.Count-1; i >= 0; i--)
{
    List<string> currentList = array[i]
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToList();
    for (int j = 0; j < currentList.Count; j++)
    {
        input.Add(currentList[j]);
    }
}
Console.WriteLine(string.Join(" ",input));
