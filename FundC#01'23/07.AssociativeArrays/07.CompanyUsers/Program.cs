int n = int.Parse(Console.ReadLine());
Dictionary<string, List<double>> infoStudents= new Dictionary<string, List<double>>();
for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    double grades = double.Parse(Console.ReadLine());
    if (infoStudents.ContainsKey(name))
    {
        infoStudents[name].Add(grades);

    }
    else
    {
        infoStudents.Add(name, new List<double>());
        infoStudents[name].Add(grades);
    }
}
var avrGradeHigherThan = infoStudents.Where(g => g.Value.Average() >= 4.50);
foreach (var (key, value) in avrGradeHigherThan)
{
    Console.WriteLine($"{key} -> {value.Average():F2}");
}