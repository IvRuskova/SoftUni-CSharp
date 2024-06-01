
using System.Text.RegularExpressions;

var regex = @"\+359([-|\s])2\1[0-9]{3}\1[0-9]{4}\b";
var phones= Console.ReadLine();
var phoneMatches = Regex.Matches(phones, regex);
var matchedPhones = phoneMatches
    .Cast<Match>()
    .Select(a=>a.Value.Trim())
    .ToArray();
Console.WriteLine(string.Join(", ",matchedPhones));
