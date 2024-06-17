
int numberOfMessages = int.Parse(Console.ReadLine());
Random rand =new Random();
List<string> phrases = new List<string>()
{
    "Excellent product.",
    "Such a great product.",
    "I always use that product.",
    "Best product of its category.",
    "Exceptional product.",
    "I can’t live without this product."
};
List<string> events = new List<string>() 
{
    "Now I feel good.",
    "I have succeeded with this product.",
    "Makes miracles. I am happy of the results!",
    "I cannot believe but now I feel awesome.",
    "Try it yourself, I am very satisfied.",
    "I feel great!"
};
List<string> authors = new List<string>()
{
    "Diana",
    "Petya",
    "Stella",
    "Elena",
    "Katya",
    "Iva",
    "Annie",
    "Eva"
};
List<string> cities = new List<string>()
{
    "Burgas",
    "Sofia",
    "Plovdiv",
    "Varna",
    "Ruse"
};
for (int i = 1; i <= numberOfMessages; i++)
{
    int phraseIndex = rand.Next(phrases.Count);
    int eventIndex = rand.Next(events.Count);
    int authorIndex = rand.Next(authors.Count);
    int cityIndex = rand.Next(cities.Count);
    Console.WriteLine($"{phrases[phraseIndex]} {events[eventIndex]} {authors[authorIndex]} - {cities[cityIndex]}");
}