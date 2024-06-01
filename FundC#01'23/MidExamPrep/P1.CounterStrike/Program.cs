
int energy = int.Parse(Console.ReadLine());
string command = Console.ReadLine();

int battleWon = 0;
bool enoughEnergy = true;

while (command != "End of battle")
{
    int distance = int.Parse(command);
	if (energy - distance < 0)
	{
		enoughEnergy = false;
		break;
	}
	energy -= distance;
	battleWon++;
	if (battleWon %3 == 0 )
	{
		energy += battleWon;
	}
	command = Console.ReadLine();
}

if (enoughEnergy)
{
	Console.WriteLine($"Won battles: {battleWon}. Energy left: {energy}");
}
else
{
	Console.WriteLine($"Not enough energy! Game ends with {battleWon} won battles and {energy} energy");
}