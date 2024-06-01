string input = Console.ReadLine();
string result = string.Empty;
for (int i = 0; i < input.Length; i++)
{
    if (i == input.Length - 1)
    {
        result += input[i];
        break;
    }
    else if (input[i] != input[i + 1])
        result += input[i];
}
Console.WriteLine(result);