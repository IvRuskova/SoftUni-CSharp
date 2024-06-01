string input = Console.ReadLine();
input = input.Replace(" ", string.Empty);

List<string> listInput = input.Split("|").ToList();
listInput.Reverse();

string output = string.Empty;

foreach (string item in listInput)
{
    output += item;
}
foreach (var item in output)
{
	if (item != '-')
	{
		Console.Write(item+ " ");
	}
	else
	{
		Console.Write(item);
	}
}

