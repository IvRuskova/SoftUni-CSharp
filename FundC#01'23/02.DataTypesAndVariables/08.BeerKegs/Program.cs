using System.Numerics;

//Input
byte n = byte.Parse(Console.ReadLine());

//Save bigger model 
double volume = double.MinValue;
string biggerModel = string.Empty;

//Act
for (int i = 1; i <= n; i++)
{
    string model=Console.ReadLine();
    double radius=double.Parse(Console.ReadLine());
    uint height = uint.Parse(Console.ReadLine());

    double volumeKeg = Math.Pow(radius,2) * height * Math.PI;
    if (volumeKeg > volume)
    {
        volume = volumeKeg;
        biggerModel = model;
    }
}
Console.WriteLine(biggerModel);
//Output
