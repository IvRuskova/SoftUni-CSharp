﻿Dictionary<string, List<double>> order = new Dictionary<string, List<double>>();

string input = Console.ReadLine();

while (input != "buy")
{
    string[] cmdArgs = input.Split();
    string name = cmdArgs[0];
    double price = double.Parse(cmdArgs[1]);
    double quantity = double.Parse(cmdArgs[2]);

    if (!order.ContainsKey(name))
    {
        var addToList = new List<double>() { price, quantity };
        order.Add(name, addToList);
    }
    else
    {
        var currentList = order[name];

        currentList[0] = price;
        currentList[1] += quantity;
        order[name] = currentList;
    }

    input = Console.ReadLine();
}

foreach (var item in order)
{
    Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]:f2}");
}
