// Input
int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray(); 

int count = 0;
int maxLength = 0;
int maxNum = 0;

//Act
for (int i = 0; i < array.Length; i++)
{
    
    for (int k = i; k < array.Length; k++)
    {
        if (array[i] == array[k])
        {
            count++;
            if (count>maxLength)
            {
                maxLength = count;
                maxNum = array[i];
            }
            continue;
        }
        count = 0;
    }
    count = 0;
}

//Output
for (int j = 0; j < maxLength; j++)
{
    Console.Write($"{maxNum} ");
}