//List<int> tools = Console.ReadLine()
//                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
//                    .Select(int.Parse)
//                    .ToList();
//List<int> substances = Console.ReadLine()
//                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
//                    .Select(int.Parse)
//                    .ToList();
//List<int> challenges = Console.ReadLine()
//                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
//                    .Select(int.Parse)
//                    .ToList();

//while (challenges.Count > 0 && tools.Count > 0 && substances.Count > 0)
//{
//    int tool = tools[0];
//    int substance = substances[substances.Count - 1];
//    int result = tool * substance;

//    if (challenges.Contains(result))
//    {
//        challenges.Remove(result);
//        tools.RemoveAt(0);
//        substances.RemoveAt(substances.Count - 1);
//    }
//    else
//    {
//        tools.RemoveAt(0);
//        substances[substances.Count - 1]--;
//        if (substances[substances.Count - 1] == 0)
//            substances.RemoveAt(substances.Count - 1);

//        tools.Add(tool + 1);
//    }
//}

//if (challenges.Count == 0)
//{
//    Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
//    Console.WriteLine("Substances: " + string.Join(", ", substances));
//}
//else
//{
//    Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
//    Console.WriteLine("Tools: " + (tools.Count > 0 ? string.Join(", ", tools) : "None"));
//    Console.WriteLine("Challenges: " + (challenges.Count > 0 ? string.Join(", ", challenges) : "None"));
//}
int[] tool = Console.ReadLine()
.Split(" ", StringSplitOptions.RemoveEmptyEntries)
.Select(int.Parse)
.ToArray();

int[] substance = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[] challange = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();


Stack<int> substances = new Stack<int>(substance);
Queue<int> tools = new Queue<int>(tool);
List<int> challenges = new List<int>(challange);


while (tools.Any() && substances.Any() && challenges.Any())
{

    int num1 = substances.Peek();
    int num2 = tools.Peek();

    int result = num1 * num2;

    if (challenges.Contains(result))
    {
        substances.Pop();
        tools.Dequeue();
        challenges.Remove(result);

    }
    else
    {
        int toolElement = tools.Dequeue() + 1;
        tools.Enqueue(toolElement);

        int substanceValue = substances.Pop() - 1;
        if (substanceValue > 0)
        {
            substances.Push(substanceValue);
        }
    }

}

if ((substances.Count == 0 || tools.Count == 0) && challenges.Count > 0)
{
    Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
}
else
{
    Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
}


if (tools.Any())
{
    Console.WriteLine($"Tools: {string.Join(", ", tools)}");

}
if (substances.Any())
{
    Console.WriteLine($"Substances: {string.Join(", ", substances)}");

}
if (challenges.Any())
{
    Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");

}