namespace FoodShortage

{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            List<IIdentifalable> enterList = new List<IIdentifalable>();
            while ((command=Console.ReadLine()) != "End")
            {
                string[] enterIdent = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                //Human
                if (enterIdent.Length == 3)
                {
                    string name = enterIdent[0];
                    int age = int.Parse(enterIdent[1]);
                    string id = enterIdent[2];
                    IIdentifalable citizen = new Citizens(id, name, age);
                    enterList.Add(citizen);
                }
                //robots
                else if (enterIdent.Length == 2)
                {
                    string model = enterIdent[0];
                    string id = enterIdent[1];
                    IIdentifalable robot = new Robots(id, model);
                    enterList.Add(robot);
                }
            }
            string lastDigits = Console.ReadLine();
            List<IIdentifalable> detainedEnters = new List<IIdentifalable>();
            for (int i = 0; i < enterList.Count; i++)
            {
                if (enterList[i].Id.EndsWith(lastDigits))
                {
                    detainedEnters.Add(enterList[i]);
                }
            }
            Console.WriteLine(String.Join(Environment.NewLine, detainedEnters.Select(c=>c.Id)));
        }
    }
}