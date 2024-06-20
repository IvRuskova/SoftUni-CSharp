string srt = Console.ReadLine();
MiddleCharacter(srt);

static void MiddleCharacter(string srt)
{
    int newSrt = srt.Length;
    int middle = newSrt / 2;
    if (newSrt % 2 == 0)
    {
        Console.Write(srt[middle - 1]);   
    }
    Console.WriteLine(srt[middle]);
}
