int startIndex = int.Parse(Console.ReadLine());
int endIndex = int.Parse(Console.ReadLine());
if (startIndex>=0 || endIndex<=255)
{
	for (int i = startIndex; i <= endIndex; i++)
	{
        Console.Write((char)i+ " ");
    }
}