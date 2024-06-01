//Input
int nPokePower=int.Parse(Console.ReadLine());
int mDistance = int.Parse(Console.ReadLine());
int yFactor =  int.Parse(Console.ReadLine());

//Act
int pokes = 0;
int pokePower = nPokePower;
while (pokePower>=mDistance)
{
    pokePower -= mDistance;
    pokes++;
    if (pokePower == nPokePower/2)
    {
        if (yFactor>0)
        {
            pokePower /= yFactor;
        }
    }
}
//Output
//Print what has remained of N, after subtracting from it.
Console.WriteLine(pokePower);
//Print the count of targets, you’ve managed to poke.
Console.WriteLine(pokes);