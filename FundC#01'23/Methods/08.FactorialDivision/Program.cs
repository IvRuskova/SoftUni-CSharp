
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        long factorielOne = GetFactorielFirstNumber(firstNum);
        long factorielTwo = GetFactorielSecondNumber(secondNum);

        double result = (factorielOne * 1.0 / factorielTwo);
        Console.WriteLine($"{result:F2}");
    
    static long GetFactorielFirstNumber(int firstNum)
    {
        long factorialOne = 1;

        for (int i = 1; i <= firstNum; i++)
        {
            factorialOne *=  i;
        }
        return factorialOne;
    }

    static long GetFactorielSecondNumber(int secondNum)
    {
        long factorialTwo = 1;

        for (int i = 1; i <= secondNum; i++)
        {
        factorialTwo *= i;
    }
        return factorialTwo;
    }
