
List <int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
string command; //23 1 456 63 32 87 9 32

while ((command=Console.ReadLine())!="end")
{
    string[] tokens = command.Split();
    if (command == "Add") //Add 1
    {
        int numberToAdd = int.Parse(tokens[1]);
        numbers.Add(numberToAdd);
        continue;
    }
    else if (command == "Remove") //Remove 5
    {
        int numberToRemove = int.Parse(tokens[1]);
        numbers.Remove(numberToRemove);
        continue;
    }
    else if (command == "RemoveAt") //RemoveAt 3
    {
        int indexToRemove = int.Parse(tokens[1]);
        numbers.RemoveAt(indexToRemove);
        continue;
    }
    else if (command == "Insert") //Insert 14 2
    {
        int numberToInsert = int.Parse(tokens[1]);
        int indexToInsert = int.Parse(tokens[2]);   
        numbers.Insert(indexToInsert, numberToInsert);
        continue;
    }
}
Console.WriteLine(string.Join(" ", numbers));