
string[] players = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries);
Queue<string> queue = new(players);

int number = int.Parse(Console.ReadLine());

int counter = 0;
while (queue.Count > 1)
{
    counter++;
    string currentPlayer = queue.Dequeue();
    if (counter == number)
    {
        Console.WriteLine($"Removed {currentPlayer}");
        counter = 0;
    }
    else
    {
        queue.Enqueue(currentPlayer);
    }
}
Console.WriteLine($"Last is {queue.Dequeue()}");