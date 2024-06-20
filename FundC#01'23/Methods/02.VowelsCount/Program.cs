
PrintVowels(Console.ReadLine().ToCharArray());

static void PrintVowels(char[] word)
{

	int count = 0;
	for (int i = 0; i < word.Length; i++)
	{


		switch (word[i])
		{
			case 'a':
			case 'e':
			case 'i':
			case 'o':
			case 'u':
			case 'y':
			case 'A':
			case 'E':
			case 'I':
			case 'O':
			case 'U':
			case 'Y':
				count++;
				break;
		}
		
	}
    Console.WriteLine(count);
}