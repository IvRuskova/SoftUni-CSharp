
int number = int.Parse(Console.ReadLine());
string input = Console.ReadLine();

Queue<string> queue = new();
int totalPassed = 0;
while (input != "end")
{
	if (input == "green")
	{
		int currentPassed = 0;
		while (currentPassed < number && queue.Count>0)
		{
            Console.WriteLine($"{queue.Dequeue()} passed!");
			currentPassed++;
        }
		totalPassed += currentPassed;
	}
	else
	{
		queue.Enqueue(input);
	}
	input= Console.ReadLine();
}
Console.WriteLine($"{totalPassed} cars passed the crossroads.");