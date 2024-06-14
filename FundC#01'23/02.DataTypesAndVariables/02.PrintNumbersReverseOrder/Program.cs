//Input
int n = int.Parse(Console.ReadLine());
int[] number = new int[n];

//Act
for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    number[i]= num;
	
}

//Output
for (int i = number.Length-1; i >= 0; i--)
{
    Console.WriteLine(number[i] + " ");
}

/*
 int n = int.Parse(Console.ReadLine());
int[] number = new int[n];
for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    number[i]= num;
}
int reverseNumber = number.Reverse().ToArray();
 */