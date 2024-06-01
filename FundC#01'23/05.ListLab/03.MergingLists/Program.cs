
////  Read the two lists.
//List<int> num1 = Console.ReadLine()
//    .Split()
//    .Select(int.Parse)
//    .ToList();

//List<int> num2 = Console.ReadLine()
//    .Split()
//    .Select(int.Parse)
//    .ToList();

////  Create a result list.
//List<int> nums = new();
////  Start looping through them until you reach the end of the smallest one.
//for (int i = 0; i < Math.Min(num1.Count,num2.Count); i++)
//{
//    nums.Add(num1[i]);
//    nums.Add(num2[i]);
//    if (num1.Count>num2.Count)
//    {
//        nums.AddRange(GetRemainingElements(num1, num2));
//    }
//    else if (num2.Count>num1.Count)
//    {
//        nums.AddRange(GetRemainingElements(num2, num1));
//    }
//}
//Console.WriteLine(string.Join(" ",nums));
////	Finally, add the remaining elements (if there are any) to the end of the list.
//static List<int> GetRemainingElements(List<int> longerList, List<int> shorterList)
//{
//    List<int> result = new List<int>();
//    for (int i = shorterList.Count; i < longerList.Count; i++)
//    {
//        result.Add(longerList[i]);
//    }

//    return result;
//}

List<int> numbers1 = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList();

int longerList = Math.Max(numbers1.Count, numbers2.Count);
List<int> result = new();

for (int i = 0; i < longerList; i++)
{
    if (i < numbers1.Count)
    {
        result.Add(numbers1[i]);
    }

    if (i < numbers2.Count)
    {
        result.Add(numbers2[i]);
    }
}
Console.WriteLine(string.Join(" ", result));

