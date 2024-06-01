using System;

List<int> numbers = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] command = input.Split();

    
    if (command[0] == "Remove")
    {
        if (int.Parse(command[1]) > numbers.Count)
        {
            Console.WriteLine("Invalid index");
            continue;
        }
        numbers.RemoveAt(int.Parse(command[1]));
    }
    else if (command[0] == "Insert")
    {
        
        if (int.Parse(command[2]) > numbers.Count)
        {
            Console.WriteLine("Invalid index");
            continue;
        }
        else
        {
            numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
        }
    }
    else if (command[0] == "Add")
    {
        numbers.Add(int.Parse(command[1]));
    }
    else if (command[0] == "Shift")
    {
        if (command[1] == "left")
        {
            for (int i = 0; i < int.Parse(command[2]); i++)
            {
                int firstNum = numbers[0];
                numbers.Remove(numbers[0]);
                numbers.Add(firstNum);
            }
        }
        else if (command[1] == "right")
        {
            for (int i = 0; i < int.Parse(command[2]); i++)
            {
                int lastNum = numbers[numbers.Count - 1];
                numbers.Remove(numbers[numbers.Count - 1]);
                numbers.Insert(0, lastNum);
            }
        }
    }
       
}
Console.WriteLine(string.Join(" ", numbers));
