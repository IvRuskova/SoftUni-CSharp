namespace BirthdayCelebrations
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
           List<IBirthable> list = new List<IBirthable>();
            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command0 = input[0];
                switch (command0)
                {
                    case "Citizen":
                        IBirthable citizen = new Citizens(input[3], input[1], int.Parse(input[2]), input[4]);
                       list.Add(citizen);
                        break;
                    case "Pet":
                        IBirthable pet = new Pets(input[1], input[2]);
                        list.Add(pet);
                        break;            
                }
            }
            string year = Console.ReadLine();
            foreach (var element in list)
            {
                if (element.Birthdate.EndsWith(year))
                {
                    Console.WriteLine(element.Birthdate);
                }
            }
        }
    }
}