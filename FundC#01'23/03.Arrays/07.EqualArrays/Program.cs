﻿int[] firstArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] secondArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int totalSum = 0;
bool areSame = true;

for (int i = 0; i < firstArray.Length; i++)
{
    totalSum +=firstArray[i];
    if (firstArray[i] != secondArray[i])
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index.");
        areSame = false;
        break;
    }
}
if (areSame)
{
    Console.WriteLine($"Arrays are identical. Sum: {totalSum}");
}