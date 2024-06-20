using System.Text.RegularExpressions;

//var regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})(?<year>\d{4})\b";
//var enterDate= Console.ReadLine();
//var dates = Regex.Matches(enterDate, regex);
//foreach (Match date in dates)
//{
//    var day = date.Groups["day"].Value;
//    var month1 = date.Groups["month"].Value;
//    var year1 = date.Groups["year"].Value;
//    Console.WriteLine($"Day: {day}, Month: {month1}, Year: {year1}");
//}

string patern = @"\b(?<day>\d{2})(?<sep>[.\-\/])(?<mon>[A-Z]{1}[a-z]{2})\k<sep>(?<y>[0-9]{4})\b";

string dates = Console.ReadLine();

var matches = Regex.Matches(dates, patern);

foreach (Match date in matches)
{
    var day = date.Groups["day"].Value;
    var month = date.Groups["mon"].Value;
    var year = date.Groups["y"].Value;

    Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");