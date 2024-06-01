using System.Numerics;

double neededExperience = double.Parse(Console.ReadLine());
int countOfBattles = int.Parse(Console.ReadLine());

double allExperince = 0;

for (int i = 1; i <= countOfBattles; i++)
{
    //one more variable for experienceEarnedPerBattle
    double experienceEarnedPerBattle = int.Parse(Console.ReadLine());
    if (i % 3 == 0)
    {
        experienceEarnedPerBattle += 0.15 * experienceEarnedPerBattle;
    }
    if (i % 5 ==0)
    {
        experienceEarnedPerBattle -= 0.1 * experienceEarnedPerBattle;
    }
    if (i % 15 == 0)
    {
        experienceEarnedPerBattle += 0.05 * experienceEarnedPerBattle;
    }
    allExperince += experienceEarnedPerBattle;
    if (allExperince >= neededExperience)
    {
        Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
        return;
    }
}
Console.WriteLine($"Player was not able to collect the needed experience, {Math.Abs(neededExperience-allExperince):f2} more needed.");


