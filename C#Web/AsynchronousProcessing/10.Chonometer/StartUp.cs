using _10.Chonometer;

var chronometer = new Chronometer();
string input = string.Empty;

while ((input = Console.ReadLine()) != "exit")
{
    if (input == "start")
    {
        Task.Run(() =>
        {
            chronometer.Start();
        });
    }
    else if (input == "stop")
    {
        chronometer.Stop();
    }
    else if (input == "lab")
    {
        Console.WriteLine(chronometer.Lap());
    }
    else if (input == "laps")
    {
        if (chronometer.Laps.Count == 0)
        {
            Console.WriteLine("No current laps.");
            continue;
        }
        Console.WriteLine("Laps: ");
        for (int i = 0; i < chronometer.Laps.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{chronometer.Laps[i]}");
        }
    }
    else if (input == "reset")
    {
        chronometer.Reset();
    }
    else if(input == "time")
    {
        Console.WriteLine(chronometer.GetTime);
    }
}
chronometer.Stop();

// static long SumAsync()
//{
//    return Task.Run(() =>
//    {
//        long sum = 0;
//        for (int i = 0; i < 1000000000; i++)
//        {
//            if (i % 2 == 0)
//            {
//                sum += i;
//            }
//        }
//        return sum;
//    }).Result;
// }
//void PrintEvenNumbers(int start, int end)
//{
//    for (int i = start; i <= end; i++)
//    {
//        if (i % 2 == 0)
//        {
//            Thread thread = new Thread(() => Console.WriteLine(i));
//            thread.Start();
//            thread.Join();
//        }
//    }
//}