List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
List<int> copiedOriginal = numbers;
string command; //23 1 456 63 32 87 9 32

while ((command = Console.ReadLine()) != "end")
{
    string[] tokens = command.Split();
    if (command == "Contains") //Add 1
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
    else if (command == "Contains")
    {
        int numberContains = int.Parse(tokens[1]);
        if (numbers.Contains(numberContains)==true)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if(command == "PrintEven")
    {
        List<int> printEven = new List<int>(numbers.FindAll(n => n % 2 == 0));
        Console.WriteLine(string.Join(" ",printEven));
    }
    else if(command == "PrintOdd")
    {
        List<int> printOdd = new List<int>(numbers.FindAll(n => n % 2 == 1));
        Console.WriteLine(string.Join(" ",printOdd));
    }
    else if (command == "GetSum")
    {
        int sum = 0;
        foreach (var item in numbers)
        {
            sum += item;
        }
        Console.WriteLine(sum);
    }
    else if (command == "Filtter")
    {
        string condition = tokens[1];
        int indexToFiltter = int.Parse(tokens[2]);
        if (condition == ">")
        {
            List<int> filtter = new List<int>(numbers.Where(n => n > indexToFiltter));
            Console.WriteLine(string.Join(" ",filtter));
        }
        else if (condition == "<")
        {
            List<int> filtter = new List<int>(numbers.Where(n => n < indexToFiltter));
            Console.WriteLine(string.Join(" ", filtter));
        }
        else if (condition == "<=")
        {
            List<int> filtter = new List<int>(numbers.Where(n => n <= indexToFiltter));
            Console.WriteLine(string.Join(" ", filtter));
        }
    }
    tokens = Console.ReadLine().Split();
    command= tokens[0]; 
}
if (copiedOriginal != numbers)
{
    Console.WriteLine(string.Join(" ", numbers));
}

