
//ExaxtSumRealNumbers
int num = int.Parse(Console.ReadLine());
double sum = 0;
for (int i = 0; i < num; i++)
{
    sum += double.Parse(Console.ReadLine());
    Console.WriteLine(sum);
}
