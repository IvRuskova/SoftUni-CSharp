// See https://aka.ms/new-console-template for more information
int distanceMeters = int.Parse(Console.ReadLine());
double meteresToKilomeres = (double)distanceMeters / 1000;
Console.WriteLine($"{meteresToKilomeres:f2}");
