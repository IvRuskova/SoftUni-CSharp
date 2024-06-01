Dictionary<string, List<string>> infoCurses=new Dictionary<string, List<string>>();
string command = string.Empty;
while ((command = Console.ReadLine()) != "end")
{
    string[] data = command.Split(" : ");
    string curseName = data[0];
    string nameOfStudents = data[1];
    if (infoCurses.ContainsKey(curseName))
    {
        infoCurses[curseName].Add(nameOfStudents);    
    }
    else
    {
        infoCurses.Add(curseName, new List<string>());
        infoCurses[curseName].Add(nameOfStudents);
    }
}
foreach (var data in infoCurses)
{
    Console.WriteLine(data.Key + ": " + data.Value.Count);
    for (int i = 0; i < data.Value.Count; i++)
    {
        Console.WriteLine($"-- {data.Value[i]}");
    }
}