//List<int> numbers = Console.ReadLine()
//    .Split(" ")
//    .Select(int.Parse)
//    .ToList();
//string input = Console.ReadLine();

//while (input != "Finish")
//{
//    List<string> commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries); //["Add" , "5"]
//    int indexOne =int.Parse(commands[1]); //[1]
//    if (commands[0] == "Add")
//    {
//        numbers.Add(int.Parse(indexOne)); 
//    }
//    else if (commands[0] == "Remove")
//    {
//        numbers.Remove(indexOne));
//    }
//    else if (commands[0] == "Replace")
//    {

//        int indexReplace = int.Parse(int.Parse(commandArr[2]));
//        int index = numbers.IndexOf(indexOne);
//        if (index >= 0 )
//        {
//            numbers[index] = indexReplace;
//        }

//    }
//    else if (commands[0] == "Collapse")
//    {
//        numbers.RemoveAll(1=>1 < indexOne);
//    }
//    input = Console.ReadLine();
//}
//Console.WriteLine(string.Join(" ",numbers));

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string input = Console.ReadLine();

while (input != "Finish")
{
    List<string> commands = input.Split().ToList();
   int indexOne = int.Parse(commands[1]);

    if (commands[0] == "Add")
    {
        numbers.Add(indexOne);
    }
    else if (commands[0] == "Remove")
    {
        numbers.Remove(indexOne);
    }
    else if (commands[0] == "Replace")
    {
        var replacementIndex = int.Parse(commands[2]);

        var index = numbers.IndexOf(indexOne);

        if (index >= 0)
        {
            numbers[index] = replacementIndex;
        }
    }
    else if (commands[0] == "Collapse")
    {
        numbers.RemoveAll(l => l < indexOne);
    }

    input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));