
using System.Text.RegularExpressions;;

string pattern = @"[@#]+(?<color>[a-z]{3,})[@#]+\W*\/+(?<amount>[0-9]+)\/+";
string input = Console.ReadLine();
var matches = Regex.Matches(input, pattern);
foreach (Match match in matches)
{
    string color = match.Groups["color"].Value;
    int amount = int.Parse(match.Groups["amount"].Value);

    Console.WriteLine($"You found {amount} {color} eggs!");
}
