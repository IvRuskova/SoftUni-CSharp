
//Input

string[] arrayStr = Console.ReadLine()
    .Split(" ")
    .ToArray();

//Act
//for (int i = 0; i < arrayStr.Length/2; i++)
//{
//    var itemArrayStr = arrayStr[i];
//    arrayStr[i] = arrayStr[arrayStr.Length-1-i];
//    arrayStr[arrayStr.Length - 1-i] = itemArrayStr;
//}

//arrayStr = arrayStr.Reverse().ToArray();

arrayStr=arrayStr.OrderByDescending(x=>x).ToArray();

//Output
Console.WriteLine(string.Join(" ", arrayStr));