﻿namespace ClassBoxData;

internal class StartUp
{
    static void Main(string[] args)
    {
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double heigth = double.Parse(Console.ReadLine());
		try
		{
			Box box = new(length, width, heigth);
            Console.WriteLine($"Surface Area - {box.SurfaceArea():f2}");
            Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():f2}");
            Console.WriteLine($"Volume - {box.Volume():f2}");
        }
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
    }
}