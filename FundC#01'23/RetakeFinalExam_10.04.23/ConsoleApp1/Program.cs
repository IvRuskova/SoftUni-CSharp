//using System;
//using System.Text.RegularExpressions;

//public class Program
//{
//    public static void Main()
//    {
//        string[] inputs = Console.ReadLine().Split();

//        string regex = @"^([\#\$\&])([a-zA-Z]+)\1\=(\d+)\!\!([a-zA-Z\d]{" + (16 - 2) + @"}[\w\d]*)$";
//        // 1st group - the starting character (#,$,&)
//        // 2nd group - the name of the racer
//        // 3rd group - the length of the geohashcode
//        // 4th group - the geohashcode (16-2 characters)

//        foreach (string input in inputs)
//        {
//            Match match = Regex.Match(input, regex);
//            if (match.Success)
//            {
//                string startingChar = match.Groups[1].Value;
//                string name = match.Groups[2].Value;
//                int length = int.Parse(match.Groups[3].Value);
//                string geohashcode = match.Groups[4].Value;

//                if (geohashcode.Length == length)
//                {
//                    geohashcode = IncrementGeohashcode(geohashcode);
//                    Console.WriteLine($"Coordinates found! {name} -> {geohashcode}");
//                }
//                else
//                {
//                    Console.WriteLine("Nothing found!");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Nothing found!");
//            }
//        }
//    }

//    public static string IncrementGeohashcode(string geohashcode)
//    {
//        char[] chars = geohashcode.ToCharArray();
//        for (int i = 0; i < chars.Length; i++)
//        {
//            chars[i] = (char)((int)chars[i] + 16);
//        }
//        return new string(chars);
//    }
//}
using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        string[] inputs = Console.ReadLine().Split();

        string regex = @"^([\#\$\&])([a-zA-Z]+)\1\=(\d+)\!\!([a-zA-Z\d]{" + (16 - 2) + @"}[\w\d]*)$";
        // 1st group - the starting character (#,$,&)
        // 2nd group - the name of the racer
        // 3rd group - the length of the geohashcode
        // 4th group - the geohashcode (16-2 characters)

        foreach (string input in inputs)
        {
            Match match = Regex.Match(input, regex);
            if (match.Success)
            {
                string startingChar = match.Groups[1].Value;
                string name = match.Groups[2].Value;
                int length = int.Parse(match.Groups[3].Value);
                string geohashcode = match.Groups[4].Value;

                if (geohashcode.Length == length)
                {
                    geohashcode = IncrementGeohashcode(geohashcode);
                    Console.WriteLine($"Coordinates found! {name} -> {geohashcode}");
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
            else
            {
                Console.WriteLine("Nothing found!");
            }
        }
    }

    public static string IncrementGeohashcode(string geohashcode)
    {
        char[] chars = geohashcode.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            chars[i] = (char)((int)chars[i] + 16);
        }
        return new string(chars);
    }
}

