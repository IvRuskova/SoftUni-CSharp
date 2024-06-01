
string[] firstArray = Console.ReadLine().Split();
string[] secondArray = Console.ReadLine().Split();

for (int i = 0; i < secondArray.Length; i++)
{
    string currElement = secondArray[i];
	if (firstArray.Contains(currElement))
	{
		Console.Write(currElement+" ");
	}
}
