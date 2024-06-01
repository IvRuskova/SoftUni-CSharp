int[] input = Console.ReadLine()
   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
   .Select(int.Parse)
   .ToArray();
Queue<int> queue = new(input.Where(x=> x % 2 == 0 ));
Console.WriteLine(string.Join(", ", queue));

