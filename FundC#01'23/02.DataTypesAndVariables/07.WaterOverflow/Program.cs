
byte n = byte.Parse(Console.ReadLine());
int cntLiters = 0;
for (int i = 1; i <= n; i++)
{
    short liters = short.Parse(Console.ReadLine());
	cntLiters += (int)liters;
	if (cntLiters > 255)
	{
		Console.WriteLine("Insufficient capacity!");
		cntLiters -= liters;
	}	
}
Console.WriteLine(cntLiters);