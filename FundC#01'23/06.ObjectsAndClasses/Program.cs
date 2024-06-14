namespace _06.ObjectsAndClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int newIndex = rnd.Next(0, words.Length);
                string currWord = words[i];
                words[i] = words[newIndex];
                words[newIndex] =currWord;
            }
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
