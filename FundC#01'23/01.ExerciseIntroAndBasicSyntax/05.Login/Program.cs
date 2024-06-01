
string username = Console.ReadLine();
string password = string.Empty;
for (int i = username.Length-1; i >=0; i--)
{
    char currCh = username[i];
    //Console.Write(currCh + " ");
    password += currCh;
}
int totalTries = 0;
string enteredPassword;
while ((enteredPassword = Console.ReadLine())!=password)
{
    totalTries++;
    if (totalTries >=4)
    {
        Console.WriteLine($"User {username} is blocked!");
        return;
    }
    else
    {
        Console.WriteLine("Incorrect password. Try again.");
    }
}

Console.WriteLine($"User {username} logged in.");