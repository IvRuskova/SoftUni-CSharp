
//read text
string text = Console.ReadLine();

Dictionary<char, int> final = new Dictionary<char, int>();
foreach (var ch in text) //loop text by index
{
    if (!final.ContainsKey(ch)) //dictionary != ch
    {
        final.Add(ch, 1);
    }
    else if (final.ContainsKey(ch))
    {
        final[ch]++;
    }
}
foreach (KeyValuePair<char, int> ch in final.Where(a => a.Key != ' '))
{
    Console.WriteLine($"{ch.Key} -> {ch.Value}");
}