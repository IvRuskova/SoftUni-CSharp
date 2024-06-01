
using System.Numerics;

int num1 = int.Parse(Console.ReadLine());   
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());   
int num4 = int.Parse(Console.ReadLine());

long firstResult = (long)num1 + num2;
long secondResult = (long)firstResult / num3;
BigInteger thirdResult = (BigInteger)secondResult * num4;
Console.WriteLine(thirdResult);

