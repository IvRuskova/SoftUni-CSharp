int n = int.Parse(Console.ReadLine());
//for (int i = 0; i <= n-1; i++)
//{
//    for (int j = 0; j <= n - 1; j++)
//    {
//        for (int k = 0; k <= n - 1; k++)
//        {
//            char letterI = (char)('a' + i);
//            char letterJ = (char)('a' + j);
//            char letterK = (char)('a' + k);
//            Console.WriteLine($"{letterI}{letterJ}{letterK}");
//        }
//    }
//}
for (char i = 'a'; i < 'a'+n; i++)
{
	for (char j = 'a'; j < 'a'+n; j++)
	{
		for (char k = 'a'; k < 'a'+n; k++)
		{
            Console.WriteLine($"{i}{j}{k}");
        }
	}
}