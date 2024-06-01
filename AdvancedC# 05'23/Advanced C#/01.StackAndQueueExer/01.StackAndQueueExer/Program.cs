namespace _01.StackAndQueueExer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new();
            foreach (char ch in input)
            {
                stack.Push(ch);                
            }
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
/* var reversed = new Stack<char>();
            Console.ReadLine().ToCharArray().ToList().ForEach(x => reversed.Push(x));
            Console.WriteLine(string.Join(string.Empty, reversed));
*/