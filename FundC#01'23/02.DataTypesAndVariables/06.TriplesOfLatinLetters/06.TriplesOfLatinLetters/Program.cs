
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
	for (int j = 0; j < n; j++)
	{
		for (int k = 0; k < n; k++)
		{
            char firstChar = (char)('a' + i);
            Console.Write(firstChar);

            char seconrChar = (char)('a' + j);
            Console.Write(seconrChar);

            char thirdChar = (char)('a' + k);
			Console.Write(thirdChar);

			Console.WriteLine();
		}
	}
}