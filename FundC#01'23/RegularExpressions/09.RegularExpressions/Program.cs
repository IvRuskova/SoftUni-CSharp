
using System.Text.RegularExpressions;

string nameList = Console.ReadLine();
string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(nameList);
foreach (Match match in matches)
{
    Console.WriteLine($"{match.Value}");
}
Console.WriteLine();