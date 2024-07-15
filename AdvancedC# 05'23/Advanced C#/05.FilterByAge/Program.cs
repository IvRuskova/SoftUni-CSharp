int count = int.Parse(Console.ReadLine());
List<Person> people = new List<Person>();

Func<Person, string, int, bool> ageFilter = (a, b, c) => b == "older" ? a.Age >= c : a.Age < c;
Func<Person, string[], string> formater = (a, arr) =>
{
    string output = string.Empty;
    if (arr.Length == 1)
    {
        if (arr[0] == "name")
        {
            output = "{0}";
        }
        else
        {
            output = "{1}";
        }
    }
    else
    {
        output = "{0} - {1}";
    }
    return string.Format(output,a.Name,a.Age);
};
for (int i = 0; i < count; i++)
{
    string[] data = Console.ReadLine()
        .Split(", ", StringSplitOptions.RemoveEmptyEntries);
    people.Add(new Person { Name = data[0], Age = int.Parse(data[1]) });
}

string condition = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
string[] format = Console.ReadLine().Split();

Console.WriteLine(string.Join(Environment.NewLine, people.Where(a=>ageFilter(a,condition,age)).Select(a=>formater(a,format))));

class Person
{
    public string Name { get; set; }

    public int Age { get; set; }
}