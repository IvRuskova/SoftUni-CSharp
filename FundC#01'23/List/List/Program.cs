
List<int> wagons= Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();
int maxCapacity = int.Parse(Console.ReadLine());
string input;
while ((input =Console.ReadLine()) != "end")
{
    string[] command = input.Split();
    if (command.Length == 1)
    {
        int passangers = int.Parse(command[0]);
        for (int i = 0; i < wagons.Count; i++)
        {
            if (wagons[i]+passangers <= maxCapacity)
            {
                wagons[i] += passangers;
                break;
            }
        }
    }
    else
    {
        int wagonsPassangers = int.Parse(command[1]);
        wagons.Add(wagonsPassangers);
    }
}
Console.WriteLine(String.Join(' ',wagons));