
int specialNum = int.Parse(Console.ReadLine());
int sum = 0;
    while (specialNum != 0)
    {
       int digits = specialNum % 10;
        sum += digits;
        specialNum /= 10;
    }
Console.WriteLine(sum);