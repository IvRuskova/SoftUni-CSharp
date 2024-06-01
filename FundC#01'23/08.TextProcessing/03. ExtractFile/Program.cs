string input = Console.ReadLine();

int index = input.LastIndexOf('\\');

input = input.Substring(index + 1);

index = input.IndexOf('.');

string name = new string(input.Substring(0, index)); 
string extension = new string(input.Substring(index + 1)); 
Console.WriteLine($"File name: {name}");
Console.WriteLine($"File extension: {extension}");