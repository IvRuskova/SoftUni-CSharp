string input = Console.ReadLine();
string encrypt = string.Empty;
foreach (char ch in input)
{
    int charCode = ch + 3;
    encrypt += (char)charCode;
}
Console.WriteLine(encrypt);