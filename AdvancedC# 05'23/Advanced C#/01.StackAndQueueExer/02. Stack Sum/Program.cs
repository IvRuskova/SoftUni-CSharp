
int[] input =Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

Stack<int> stack = new(input);

string command = Console.ReadLine().ToLower();

while (command!="end")
{
    string[] command0 = command.Split();
    if (command0[0] == "add")
    {
        
        int numAdd = int.Parse(command0[1]);
        int numAddSecon = int.Parse(command0[2]);
        stack.Push(numAdd); 
        stack.Push(numAddSecon);
    }
    else if (command0[0] =="remove")
    {
        int numRemove = int.Parse(command0[1]);
        if (numRemove<= stack.Count)
        {
            for (int i = 0; i < numRemove; i++)
            {
                stack.Pop();
            }    
        }
    }
    command = Console.ReadLine().ToLower();
}
int sum = stack.Sum();
Console.WriteLine($"Sum: {sum}");
