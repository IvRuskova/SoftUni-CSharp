using System.Text;

string messege = Console.ReadLine();
string command;
StringBuilder sb = new StringBuilder();
sb.Append(messege);

while ((command = Console.ReadLine()) != "Decode")
{
    List<string> inputs = command.Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();
    string action = inputs[0];
    if (action == "Move")
    {
        int numberOfLetters = int.Parse(inputs[1]);
        string lettersToMove = messege.Substring(0, numberOfLetters);  
        messege = messege.Remove(0,numberOfLetters);
        messege += lettersToMove;
    }
    else if (action == "Insert")
    {
        int index = int.Parse(inputs[1]);
        string value = inputs[2];
        messege = messege.Insert(index,value);
    }
    else if (action == "ChangeAll")
    {
        string substring = inputs[1];
        string replacement = inputs[2];
        messege = messege.Replace(substring, replacement);
    }
}
Console.WriteLine($"The decrypted message is: {messege}");
