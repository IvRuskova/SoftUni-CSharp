
int specialNumber = int.Parse(Console.ReadLine());
int sum = 0;
int num = 0;
bool checkSum = false;
for (int i = 1; i <= specialNumber; i++)
{
    num = i;
    while (i > 0)
    {
        sum += i % 10;
        i /= 10;
    }
    checkSum = (sum == 5) || (sum == 7) || (sum == 11);
    Console.WriteLine("{0} -> {1}", num, checkSum);
    sum = 0;
    i = num;
}