//Input
List<int> nums = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
int sum = 0;

//Act
while (nums.Count != 0)
{
    int index = int.Parse(Console.ReadLine());
    bool isGreater = false;
    bool isLess = false;
    if (index < 0 )
    {
        index = 0;
        isLess = true;
    }
    if (index> nums.Count - 1)
    {
        index = nums.Count - 1;
        isGreater = true;
    }
    for (int i = 0; i < nums.Count; i++)
    {
        if (i == index)
        {
            continue;
        }
        if (nums[i] > nums[index])
        {
            nums[i] -= nums[index];
        }
        else
        {
            nums[i] += nums[index];
        }
    }
    sum += nums[index];
    if (isLess)
    {
        nums[0] = nums[nums.Count - 1];
    }
    if (isGreater)
    {
        nums[nums.Count - 1] = nums[0];
    }
    if (isGreater || isLess)
    {
        continue;
    }
    nums.RemoveAt(index);
}

//Output
Console.WriteLine(sum);