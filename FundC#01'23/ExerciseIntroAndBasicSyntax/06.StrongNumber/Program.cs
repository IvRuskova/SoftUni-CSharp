

int n = int.Parse(Console.ReadLine());
int numCopy = n;
int factorialSum = 0;
while (numCopy > 0)
{
    int lastDigit = numCopy % 10; //Take last digit
    numCopy /= 10; // Remove the taken digit

    int factorial = 1; // Store a product -> start from 1 -> 1*n =n;
    for (int i = 2; i <= lastDigit; i++)
    {
        factorial *= i; 
    }
    factorialSum += factorial;
}
if (factorialSum ==n)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}