string[] input = Console.ReadLine()
    .Split(" ").Reverse().ToArray();

Stack<string> stack = new(input);
while (stack.Count > 1)
{
    int result = 0;
    int firstNum = int.Parse(stack.Pop());
    string operation = stack.Pop();
    int secondNum = int.Parse(stack.Pop());
    if (operation == "+")
    {
        result = firstNum + secondNum;
    }
    else if (operation == "-" )
    {
        result = firstNum - secondNum;
    }
    stack.Push(result.ToString());
}
Console.WriteLine(stack.Pop().ToString());