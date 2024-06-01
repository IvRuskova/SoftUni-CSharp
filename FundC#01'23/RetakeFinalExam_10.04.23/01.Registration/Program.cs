namespace _01.Registration
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string input = Console.ReadLine();
            while (input != "Registration")
            {
                string[] command = input.Split();

                switch (command[0])
                {
                    case "Letters":
                        if (command[1] == "Lower")
                        {
                            username = username.ToLower();
                        }
                        else if (command[1] == "Upper")
                        {
                            username = username.ToUpper();
                        }
                        Console.WriteLine(username);
                        break;

                    case "Reverse":
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);

                        if (startIndex >= 0 && endIndex < username.Length)
                        {
                            string substring = username.Substring(startIndex, endIndex - startIndex + 1);
                            char[] chars = substring.ToCharArray();
                            Array.Reverse(chars);
                            string reversed = new string(chars);
                            Console.WriteLine(reversed);
                        }
                        break;

                    case "Substring":
                        string substringToCut = command[1];

                        if (username.Contains(substringToCut))
                        {
                            username = username.Replace(substringToCut, "");
                            Console.WriteLine(username);
                        }
                        else
                        {
                            Console.WriteLine($"The username {username} doesn't contain {substringToCut}.");
                        }
                        break;

                    case "Replace":
                        char charToReplace = char.Parse(command[1]);
                        username = username.Replace(charToReplace, '-');
                        Console.WriteLine(username);
                        break;

                    case "IsValid":
                        char charToCheck = char.Parse(command[1]);
                        if (username.Contains(charToCheck))
                        {
                            Console.WriteLine("Valid username.");
                        }
                        else
                        {
                            Console.WriteLine($"{charToCheck} must be contained in your username.");
                        }
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }

}