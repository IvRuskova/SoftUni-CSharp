int firstDigit = int.Parse(Console.ReadLine());
int secondDigit = int.Parse(Console.ReadLine());    
int thirdDigit = int.Parse(Console.ReadLine());

static int Sum(int firstDigit,int secondDigit)
{
    return firstDigit + secondDigit;
}
static double Subtract(int firstDigit, int secondDigit, int thirdDigit)
{
    return Sum(firstDigit,secondDigit) - thirdDigit;
}
Console.WriteLine(Subtract(firstDigit,secondDigit,thirdDigit));
