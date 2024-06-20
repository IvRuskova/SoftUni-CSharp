string[] day = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
int number = int.Parse(Console.ReadLine());

    if (number >= 1 && number <= 7)
    {
        Console.WriteLine(day[number-1]);
    }
    else
    {
        Console.WriteLine("Invalid Day!");
    }


