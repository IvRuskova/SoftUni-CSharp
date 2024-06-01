
//using System;
//using System.Text.RegularExpressions;

//class Program
//{
//    static void Main(string[] args)
//    {

//        static void Main(string[] args)
//        {
//            string input = Console.ReadLine();
//            string pattern = @"^([#$%*&])[A-Za-z]+\1-(\d+)(!!)([A-Za-z\d]{" + @"$2" + "})\\1$";

//            Regex regex = new Regex(pattern);
//            Match match = regex.Match(input);

//            if (match.Success)
//            {
//                string name = match.Groups[0].Value.Substring(1, match.Groups[1].Value.Length - 2);
//                int length = int.Parse(match.Groups[2].Value);
//                string encryptedCode = match.Groups[4].Value;
//                string decryptedCode = DecryptCode(encryptedCode, length);

//                Console.WriteLine($"Coordinates found! {name} -> {decryptedCode}");
//            }
//            else
//            {
//                Console.WriteLine("Nothing found!");
//            }
//        }

//        static string DecryptCode(string code, int length)
//        {
//            char[] decryptedChars = new char[code.Length];
//            for (int i = 0; i < code.Length; i++)
//            {
//                char decryptedChar = (char)(code[i] + length);
//                decryptedChars[i] = decryptedChar;
//            }
//            return new string(decryptedChars);
//        }
//    }
//}




        using System;
        using System.Text.RegularExpressions;

class Program
    {
     static void Main(string[] args)
        {
        string regex = @"^([\#\$\&\%\&\*])([a-zA-Z]+)\1\=(\d+)\!\!([a-zA-Z\d]{" + (16 - 2) + @"}[\w\d]*)$";
        string input = Console.ReadLine();
        
        Match match = Regex.Match(input, regex);
            
            if (match.Success)
            {
                string name = match.Groups[2].Value;
                int length = int.Parse(match.Groups[3].Value);
                string code = match.Groups[4].Value;
                if (name.Length != length)
                {
                    Console.WriteLine("Nothing found!");
                }
                else
                {
                    string newCode = "";
                    foreach (char c in code)
                    {
                        newCode += (char)(c + length);
                    }
                    Console.WriteLine($"Coordinates found! {name} -> {newCode}");
                }
            }
            else
            {
                Console.WriteLine("Nothing found!");
            }
        input = Console.ReadLine();
    }
    }


//{
//    string input = Console.ReadLine();

//    // check if input matches the required format
//    if (!IsValidInput(input))
//    {
//        Console.WriteLine("Nothing found!");

//    }

//    // extract racer name, geohash length, and encrypted geohash code
//    string racerName = input.Split('#', '$', '%', '*', '&')[1];
//    int geohashLength = int.Parse(input.Split('=')[1]);
//    string encryptedGeohash = input.Split(new string[] { "!!" }, StringSplitOptions.None)[0].Split('=')[1];

//    // decrypt geohash code
//    string decryptedGeohash = DecryptGeohash(encryptedGeohash, geohashLength);

//    // check if decrypted geohash matches the racer name
//    if (decryptedGeohash.Equals(racerName))
//    {
//        Console.WriteLine($"Coordinates found! {racerName} -> {encryptedGeohash}");
//    }
//    else
//    {
//        Console.WriteLine("Nothing found!");
//    }
//    input = Console.ReadLine();
//}

//static bool IsValidInput(string input)
//{
//    // check if input has the required length and format
//    if (input.Length < 7 || input.IndexOf('=') == -1 || input.IndexOf("!!") == -1)
//    {
//        return false;
//    }

//    // extract racer name and check if it matches the required format
//    string racerName = input.Split('#', '$', '%', '*', '&')[1];
//    if (!racerName.Equals(racerName.ToUpper()) && !racerName.Equals(racerName.ToLower()))
//    {
//        return false;
//    }

//    // extract geohash length and check if it is valid
//    int geohashLength;
//    if (!int.TryParse(input.Split('=')[1], out geohashLength))
//    {
//        return false;
//    }

//    // extract encrypted geohash code and check if it has the required length
//    string encryptedGeohash = input.Split(new string[] { "!!" }, StringSplitOptions.None)[0].Split('=')[1];
//    if (encryptedGeohash.Length != geohashLength)
//    {
//        return false;
//    }

//    return true;
//}

//static string DecryptGeohash(string encryptedGeohash, int geohashLength)
//{
//    char[] decryptedChars = new char[geohashLength];
//    for (int i = 0; i < geohashLength; i++)
//    {
//        decryptedChars[i] = (char)(encryptedGeohash[i] + geohashLength);
//    }
//    return new string(decryptedChars);

