using System.Text.RegularExpressions;

string input = Console.ReadLine();
Regex regex =new Regex (@"([\=\/])(?<name>[A-Z][a-zA-Z]{2,})(\1)");
MatchCollection match =  regex.Matches(input);

List<string> destination = new List<string>();
int points = 0;

foreach (Match city in match)
{
	if (city.Success)
	{
		string name = city.Groups["name"].Value;
		destination.Add (name);
		points += name.Length;
	}
}
Console.WriteLine($"Destinations: {string.Join(", ", destination)}");
Console.WriteLine($"Travel Points: {points}");
