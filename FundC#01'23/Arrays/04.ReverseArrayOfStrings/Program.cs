
string[] items = Console.ReadLine()
    .Split(' ')
    .ToArray();

items = items.Reverse().ToArray();
Console.WriteLine(string.Join(" ", items));

