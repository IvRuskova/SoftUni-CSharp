internal class Program
{
    private static void Main(string[] args)
    {
        static void Main(string[] args)
        {
            //Input
            List<string> lessons = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string[] action = Console.ReadLine()
                .Split(":")
                .ToArray();

            //Act
            while (action[0] != "course start")
            {
                bool exist = lessons.Contains(action[1]);
                bool exerciseFist = lessons.Contains(action[1] + "-Exercise");
                switch (action[0])
                {
                    case "Add":
                        Add(lessons, action, exist);
                        break;
                    case "Insert":
                        Insert(lessons, action, exist);
                        break;
                    case "Remove":
                        Remove(lessons, action, exist, exerciseFist);
                        break;
                    case "Swap":
                        bool exerciseSecond = lessons.Contains(action[2] + "-Exercise");
                        Swap(lessons, action, exist, exerciseFist, exerciseSecond);
                        break;
                    case "Exercise":
                        Exercise(lessons, action, exist, exerciseFist);
                        break;
                }
                action = Console.ReadLine()
                    .Split(":")
                    .ToArray();
            }
            //Output
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }


        static void Exercise(List<string> lessons, string[] action, bool exist, bool exercise)
        {
            string exerciseLesson = action[1];
            if (exist && !exercise)
            {
                for (int i = 0; i < lessons.Count; i++)
                {
                    if (lessons[i] == exerciseLesson)
                    {
                        lessons.Insert(i + 1, exerciseLesson + "-Exercise");
                    }
                }
            }
            else
            {
                lessons.Add(exerciseLesson);
                lessons.Add(exerciseLesson + "-Exercise");
            }
        }

        static void Swap(List<string> lessons, string[] action, bool exist, bool exerciseFist, bool exerciseSecond)
        {
            string lessonSwap1 = action[1];
            string lessonSwap2 = action[2];
            if (exist)
            {
                for (int i = 0; i < lessons.Count; i++)
                {
                    if (lessons[i] != lessonSwap1)
                    {
                        continue;
                    }
                    for (int j = 0; j < lessons.Count; j++)
                    {
                        if (lessons[j] != lessonSwap2)
                        {
                            continue;
                        }
                        lessons[i] = lessonSwap2;
                        if (exerciseFist)
                        {
                            lessons.Insert(j + 1, lessons[i + 1]);
                            lessons.RemoveAt(i + 2);
                        }
                        lessons[j] = lessonSwap1;
                        if (exerciseSecond)
                        {
                            lessons.Insert(i + 1, lessons[j + 1]);
                            lessons.RemoveAt(j + 2);
                        }
                        break;
                    }
                    break;
                }
            }
        }

        static void Remove(List<string> lessons, string[] action, bool exist, bool exercise)
        {
            if (exist)
            {
                lessons.Remove(action[1]);
            }
            if (exercise)
            {
                lessons.Remove(action[1] + "-Exercise");
            }
        }

        static void Insert(List<string> lessons, string[] action, bool exist)
        {
            if (!exist)
            {
                lessons.Insert(int.Parse(action[2], action[1]));
            }
        }

        static void Add(List<string> lessons, string[] action, bool exist)
        {
            if (!exist)
            {
                lessons.Add(action[1]);
            }
        }
    }
}