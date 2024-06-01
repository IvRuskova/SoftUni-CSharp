Dictionary<string, string> contacts = new Dictionary<string, string>();
if (!contacts.ContainsKey("An"))
{
    contacts.Add("An", "+35999999999");
}
if (contacts.ContainsKey("An")) //fast
{
    string contact = contacts["An"];
    Console.WriteLine(contact);
}
if (contacts.ContainsValue("+35999999999")) //slow
{
    Console.WriteLine(true);
}
bool isDeleted = contacts.Remove("An");
Console.WriteLine(isDeleted);