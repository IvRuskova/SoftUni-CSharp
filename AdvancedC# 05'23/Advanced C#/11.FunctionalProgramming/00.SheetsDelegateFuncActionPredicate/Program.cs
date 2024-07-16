
//Delegate - type
//holds a method

delegate int Combine(int x, int y);
Combine multiply = (x, y) => x * y;
Combine add = (x, y) => x + y;
int mult = multiply(3, 5);
int summ = add(3, 5);

MyPredicate checkEqual = (num1, num2) => num1 == num2;
Console.WriteLine(checkEqual(2, 4));

delegate bool MyPredicate(int num1, int num2);

//Action<T>
void Print(string message)
{
    Console.WriteLine(message);
}
//Same
Action<string> print = message => Console.WriteLine(message);

Action<string> printt = srt => Console.WriteLine(srt);
static void Printt(string srt)=> 
    Console.WriteLine(srt);
printt(" J Jho");
Printt("JJ Jho");


//Predicate - boolean method
Predicate<int> isNegative = x => x < 0;
Console.WriteLine(isNegative(5));
Console.WriteLine(isNegative(-5));

var nums = new List<int> { 3, 5, -2, 10, 0, 3 };
var negs = nums.FindAll(isNegative);
Console.WriteLine(String.Join(", ", negs));

Predicate<int> checkEven = number => number%2 == 0;
static bool CheckEven(int number)
{
    return number % 2 == 0;
}
Console.WriteLine(checkEven(3));
Console.WriteLine(CheckEven(4));

//Func<int- input type, string-output type> func- name = (n- input parameter =>n.ToString();-return expression)- lambda expression
Func<int, string> func = n =>n.ToString();

Func<int, int, int> sum = (num1, num2) => num1 + num2;
Console.WriteLine(sum(12,7));
Console.WriteLine(sum(5, 4));

static int Sum(int num1, int num2)
{
    return num1 + num2;
}


//Can pass Func<> in method
int Operation(int number, Func<int, int> operation) 
{
    return operation(number);
}

//Higher-order function
int a = 5;
int b = Operation(a, number => number * 5);
int c = Operation(a, number => number - 3);
int d = Operation(a, number => number % 2);

//More examples
long Aggregate(int start, int end, Func<long, long, long> op)
{
    long result = start;
    for (int i = start+1; i <= end; i++)
    {
        result = op(result, i);
    }
    return result;
}
Aggregate(1, 10, (a, b) => a + b);
Aggregate(1, 10, (a, b) => a * b);
Aggregate(1, 10, (a, b) =>long.Parse("" + a + b));

//Anather
Random rand = new Random();
int[] arr = Enumerable.Range(0, 1000).ToArray();

Select(arr, n => n * 5);
Select(arr, n => n + rand.Next(0, 10000));
Select(arr, n => n / 5);
int[] Select(int[] arr,Func<int,int> operation)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = operation(arr[i]);
    }
    return arr;
}