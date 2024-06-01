Dictionary<string,List<string>> infoCompany = new Dictionary<string,List<string>>();
string command = Console.ReadLine(); 
while (command != "End")
{
    string[] info = command.Split(" -> ");
    string comnpanyName = info[0];
    string employeeId = info[1];
    if (!infoCompany.ContainsKey(comnpanyName))
    {
        infoCompany.Add(comnpanyName, new List<string>() { employeeId});
    }
    else if (!infoCompany[comnpanyName].Contains(employeeId))
    {
        infoCompany[comnpanyName].Add(employeeId);
    }
    command = Console.ReadLine();
}
foreach (var company in infoCompany)
{
    Console.WriteLine(company.Key);
    foreach (var companyId in company.Value)
    {
        Console.WriteLine($"-- {companyId}");
    }
}
