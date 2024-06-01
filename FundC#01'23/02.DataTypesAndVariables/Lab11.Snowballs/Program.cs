using System.Numerics;

int nSnowBall = int.Parse(Console.ReadLine());
//Input
BigInteger maxSnowballValue = 0;

//Act
int maxSnowballSnow = 0;
int maxSnowballTime = 0;
int maxSnowballQuantity = 0;
while (nSnowBall>0)
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());
   BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime),snowballQuality);
    if (snowballValue > maxSnowballValue)
    {
        maxSnowballValue=snowballValue;
        maxSnowballSnow = snowballSnow;
        maxSnowballTime = snowballTime;
        maxSnowballQuantity = snowballQuality;
    }
    nSnowBall--;
}

//Output
Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {maxSnowballValue} ({maxSnowballQuantity})");