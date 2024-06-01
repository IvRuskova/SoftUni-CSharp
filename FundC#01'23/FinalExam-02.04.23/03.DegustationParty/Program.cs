Dictionary<string, List<string>> clients = new Dictionary<string, List<string>>();
string input;

int disLiked = 0;

while ((input = Console.ReadLine())!= "Stop")
{
    string[] commandTokens = input.Split("-", StringSplitOptions.RemoveEmptyEntries);
    string yesOrNo = commandTokens[0];
    if (yesOrNo == "Like")
    {
        string guestName = commandTokens[1];
        string meal = commandTokens[2];
        if (clients.ContainsKey(guestName))
        {
            if (clients[guestName].Contains(meal))
            { }
            else
            {
                clients[guestName].Add(meal);
            }
        }
        else
        {
            clients.Add(guestName, new List<string>());
            clients[(guestName)].Add(meal);
        }
    }
    else if (yesOrNo == "Dislike")
    {
        string guestName = commandTokens[1];
        string meal = commandTokens[2];
        if (clients.ContainsKey(guestName))
        {
            if (clients[guestName].Contains(meal))
            {
                clients[guestName].Remove(meal);
                Console.WriteLine($"{guestName} doesn't like the {meal}.");
                disLiked++;
            }
            else
            {
                Console.WriteLine($"{guestName} doesn't have the {meal} in his/her collection.");
            }
        }
        else
        {
            Console.WriteLine($"{guestName} is not at the party.");
        }
    }
}
foreach (var client in clients)
{
    Console.WriteLine($"{client.Key}: {string.Join(", ",client.Value)}");
}
Console.WriteLine($"Unliked meals: {disLiked}");