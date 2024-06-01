int n = int.Parse(Console.ReadLine());

List<string> products = new ();

for (int i = 0; i < n; i++)
{
    string currProduct = Console.ReadLine();
    products.Add(currProduct);
}
products.Sort();

for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}.{products[i]}");
}