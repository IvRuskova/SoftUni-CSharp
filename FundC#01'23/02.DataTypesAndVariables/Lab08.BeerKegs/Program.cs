
int n = int.Parse(Console.ReadLine());
double maxVol = 0;
string modelKeg = string.Empty;
while (n > 0)
{
    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());
    double volume = Math.PI * Math.Pow(radius, 2) * height;
    if (volume>maxVol)
    {
        maxVol = volume;
        modelKeg = model;
    }
    n--;
}
Console.WriteLine(modelKeg);
