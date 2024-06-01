
int totalPeople = int.Parse(Console.ReadLine());
string groupType = Console.ReadLine();
string dayOfWeek = Console.ReadLine();
double pricePerPerson = 0;
switch (groupType)
{
    case "Students":
        switch (dayOfWeek)
        {
            case "Friday": pricePerPerson = 8.45; break;
            case "Saturday": pricePerPerson = 9.80; break;
            case "Sunday": pricePerPerson = 10.46; break;
        }
        if (totalPeople >= 30)
        {
            pricePerPerson *= 0.85;
        }
        break;
    case "Business":
        switch (dayOfWeek)
        {
            case "Friday": pricePerPerson = 10.90; break;
            case "Saturday": pricePerPerson = 15.60; break;
            case "Sunday": pricePerPerson = 16.00; break;
        }
        if (totalPeople >= 100)
        {
            totalPeople -= 10;
        }
        break;
    case "Regular":
        switch (dayOfWeek)
        {
            case "Friday": pricePerPerson = 15.00; break;
            case "Saturday": pricePerPerson = 20.00; break;
            case "Sunday": pricePerPerson = 22.50; break;
        }
        if (totalPeople >= 10 && totalPeople <= 20)
        {
            pricePerPerson *= 0.95;
        }
        break;
}
double totalPrice = totalPeople * pricePerPerson;
Console.WriteLine($"Total price: {totalPrice:F2}");
