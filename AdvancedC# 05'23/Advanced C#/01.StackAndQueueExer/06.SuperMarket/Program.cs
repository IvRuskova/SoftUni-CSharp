    
string input = Console.ReadLine();
Queue<string> queue = new();

while (input != "End")
{
	if (input == "Paid")
	{
		while (queue.Count > 0)
		{
            Console.WriteLine(queue.Dequeue());
        }
	}
	else
	{
		queue.Enqueue(input);
	}
    input = Console.ReadLine();
}
Console.WriteLine(queue.Count + " people remaining.");