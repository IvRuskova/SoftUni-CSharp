using L04.Students;

string[] data = Console.ReadLine()
    .Split();
List<Student> students = new List<Student>();
while (data[0] != "end")
{
    Student student = new Student(data[0], data[1], int.Parse(data[2]), data[3]);
    students.Add(student);
    data = Console.ReadLine().Split();
}
string filterCity = Console.ReadLine();
foreach (Student student in students)
{
    if (student.HomeTown == filterCity)
    {
        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
    }
}