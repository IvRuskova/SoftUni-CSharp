
//SpecialNumbers
int specialNum = int.Parse(Console.ReadLine());
for (int i = 1; i <= specialNum; i++)
{
    int sum = 0;
    int digits = i;
    while (digits > 0)
    {
        sum += digits % 10;
        digits /= 10;
    }
    if (sum == 5 || sum == 7 || sum == 11)
    {
        Console.WriteLine($"{i} -> True");
    }
    else
    {
        Console.WriteLine($"{i} -> False");
    }
}

    //if (i == 5)
    //{
    //    Console.WriteLine($"{i}->True");
    //}
    //else if (i == 7)
    //{
    //    Console.WriteLine($"{i}->True");
    //}
    //else if (i == 11)
    //{
    //    Console.WriteLine($"{i}->True");
    //}
    //else
    //{
    //    Console.WriteLine($"{i}->False");
    //}

