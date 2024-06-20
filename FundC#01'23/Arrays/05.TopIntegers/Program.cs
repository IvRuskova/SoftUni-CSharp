//Input
int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray(); // new array

//Act
for (int i = 1; i < array.Length; i++)
{
    int currNum = array[i]; // current index->number
    bool flag = true; // checks
    for (int j = i+1; j < array.Length; j++)
    {
        int nextNum = array[j]; // next index
        if (nextNum >= currNum) // check indexs more than bigger
        {
            flag = false;
            break;
        }
    }
    if (flag)
    {
        Console.WriteLine(currNum + " "); // Output
    }
    
}   


