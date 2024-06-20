//List<string> validUsernames = new List<string>();

//string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

//foreach (var name in input)
//{
//    if (name.Length >= 3 && name.Length <= 16)
//    {
//        bool isValid = true;

//        for (int i = 0; i < name.Length; i++)
//        {
//            char currentChar = name[i];

//            if (!(currentChar == '-' || currentChar == '_' || char.IsDigit(currentChar)) ||
//                char.IsLetter(currentChar))
//            {
//                isValid = false;
//                break;
//            }
//        }

//        if (isValid)
//        {
//            validUsernames.Add(name);
//        }
//    }
//}

//Console.WriteLine(String.Join(Environment.NewLine, validUsernames));

List<string> users = Console.ReadLine().Split(", ").ToList();

List<string> valid = users.Where(user => user.All(c => c == '-' || c == '_' || Char.IsLetterOrDigit(c)) && user.Length >= 3 && user.Length <= 16).ToList();

Console.WriteLine(string.Join("\n", valid));