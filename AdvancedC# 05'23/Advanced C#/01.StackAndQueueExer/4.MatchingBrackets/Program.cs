
string input = Console.ReadLine();

Stack<int> stack = new();

for (int i = 0; i < input.Length; i++)
{
    char ch = input[i];
	if (ch == '(')
	{
		stack.Push(i);
	}else if(ch == ')')
	{
		int start = stack.Pop();
		string contents = input.Substring(start, i - start+1);
        Console.WriteLine(contents);
    }
}