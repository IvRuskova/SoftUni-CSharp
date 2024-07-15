namespace _03.CountUppercaseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> check = n => n[0] == n.ToUpper()[0];
            string[] words = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Where( w=> check(w) )
                .ToArray();
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
