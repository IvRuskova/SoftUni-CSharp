using System;

Action<string[]> printNamesWithAddedTitle = (names) =>
{
	foreach (var name in names)
	{
        Console.WriteLine($"Sir {name}");
    }
};

string[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

printNamesWithAddedTitle(input);