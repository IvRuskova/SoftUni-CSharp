using System;

string password = Console.ReadLine();

bool isValid = true;

if (!IsLengthValid(password))
{
    isValid = false;
    Console.WriteLine("Password must be between 6 and 10 characters");
}

bool IsLengthValid(string password)
{
    return password.Length > 6 && password.Length <= 10;
}

if (!DigitAndLetters(password))
{
    isValid = false;
    Console.WriteLine("Password must consist only of letters and digits");
}

bool DigitAndLetters(string password)
{
    return password.All(char.IsLetterOrDigit);
}

if (!Contains2DigitOrMore(password))
{
    isValid = false;
    Console.WriteLine("Password must have at least 2 digits");
}

bool Contains2DigitOrMore(string password)
{

    return password.Count(char.IsDigit) >= 2;
}

if (isValid)
{
    Console.WriteLine("Password is valid");
}


