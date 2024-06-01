using System.Xml.Linq;

static void Main(string[] args)
{
    int commandNumber = int.Parse(Console.ReadLine());

    List<string> guestList = new List<string>();

    for (int i = 0; i < commandNumber; i++)
    {
        string[] commandArgs = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string name = commandArgs[0];
        if (commandArgs.Length == 3)
        {
            if (guestList.Contains(name))
            {
                Console.WriteLine($"{name} is already in the list!");
                continue;
            }
            guestList.Add(name);
        }
        else if (commandArgs.Length == 4)
        {
            if (!guestList.Contains(name))
            {
                Console.WriteLine($"{name} i not in the list!");
                continue;
            }
            guestList.Remove(name);
        }
        PrintGuestList(guestList);
    }
    static void PrintGuestList(List<string> guestList)
    {
        foreach (string name in guestList)
        {
            Console.WriteLine(name);
        }
    }
    static void PrintGuestListAlphabetically(List<string> guestList)
    {
        List<string> orderedList = guestList
        .OrderBy(e => e)
        .ToList();
        foreach (string name in orderedList)
        {
            Console.WriteLine(name);
        }
    }
}
