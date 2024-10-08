﻿using System;

Func<HashSet<int>, int> min = numbers =>
numbers.Min(x => x);
/*int min = int.MaxValue;
 foreach(var number in numbers)
{
    if(number < min)
    {
        min = number;
    }
}
return min;
 */
HashSet<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToHashSet();

Console.WriteLine(min(numbers));