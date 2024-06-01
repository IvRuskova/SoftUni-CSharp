/*	1. Reading array from the console
 * 
string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

for (int i = 0; i < dayOfWeek.Length; i++)
{
    int day = int.Parse(Console.ReadLine());
	
	if (day>=0 && day <= 7)
	{
		Console.WriteLine(dayOfWeek[day]);
	}
	else
	{
		Console.WriteLine("Invalid day!");
	}
	break;
}
*/

/*	2. Reading array elements from a one single line
 *	
int[] array = Console.ReadLine()
	.Split(", ")
	.Select(int.Parse)
	.ToArray();

Console.WriteLine(array);
*/

/*	3. Printing array on the console
 *	
string[] array = { "one", "two" };
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("array[{0}] = {1}",i,array[i]);
}
*/

/*	4. Print number in reverse order
int n = int.Parse(Console.ReadLine());
int[] array =  new int[n];
for (int i = 0; i < n; i++)
{
	array[i] = int.Parse(Console.ReadLine());
}
for (int i =n-1; i >= 0; i--)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
*/

/*	5. Rounding numberes 
double[] array = Console.ReadLine()
	.Split(' ')
	.Select(double.Parse)
	.ToArray();

for (int i = 0; i < array.Length; i++)
{
	if (array[i]==0)
	{
		array[i] = 0;
	}
	Console.WriteLine($"{array[i]} => {(int)Math.Round(array[i], MidpointRounding.AwayFromZero)}");
}*/

/*	Join method for printing array elements
int[] arr = {1, 2, 3};
Console.WriteLine(string.Join(" - ",arr));
*/


/*	6. Reverse in one array
string[] arr = Console.ReadLine()
	.Split()
	.ToArray();
for (int i = 0; i < arr.Length/2; i++)
{
	string elementN = arr[i];
	arr[i]=arr[arr.Length - 1 - i];
	arr[arr.Length-1-i]=elementN;
}
Console.WriteLine(string.Join(" ", arr));
*/

/*	7. Print array with foreach
int[] numbers = {1, 2, 3, 4, 5};
foreach (int number in numbers)
{
	Console.Write($"{number}");
}
*/

