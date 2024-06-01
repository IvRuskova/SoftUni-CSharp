List<int> numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

string input;
while ((input = Console.ReadLine()) != "end")
{
    string[] commandWithNum = input.Split(" ");
    string command = commandWithNum[0];
    int element = int.Parse(commandWithNum[1]);
    if (command == "Delete")
    {
        numbers.RemoveAll(x=> x == element);
    }
    else if (command == "Insert")
    {
        int index = int.Parse(commandWithNum[2]);
        numbers.Insert(index, element);
    }
}
Console.WriteLine(string.Join(" ",numbers));