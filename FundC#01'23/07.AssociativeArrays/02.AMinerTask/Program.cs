
internal class Program
{
	private static void Main(string[] args)
	{
		//Input
		string input = Console.ReadLine();
		//Act
		Dictionary<string, int> metals = new Dictionary<string, int>();
		
		while (input != "stop")
		{
			int quantity = int.Parse(Console.ReadLine());
			if (!metals.ContainsKey(input))
			{
				metals[input] = 0;
			}
			metals[input] += quantity;
			input = Console.ReadLine();
		}
		//Output
		foreach (var currMetals in metals)
		{
			Console.WriteLine($"{currMetals.Key} -> {currMetals.Value}");
		}
	}
}