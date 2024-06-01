//string[] dimensions = Console.ReadLine()
//    .Split(',',StringSplitOptions.RemoveEmptyEntries);
//int rows = int.Parse(dimensions[0]);
//int cols = int.Parse(dimensions[1]);

//char[,] matrix = new char[rows, cols];
//int mouseRow = -1;
//int mouseCol = -1;
//int cheeseCount = 0;

//for (int row = 0; row < rows; row++)
//{
//    string input = Console.ReadLine();
//    for (int col = 0; col < cols; col++)
//    {
//        matrix[row, col] = input[col];
//        if (matrix[row, col] == 'M')
//        {
//            mouseRow = row;
//            mouseCol = col;
//        }
//        else if (matrix[row, col] == 'C')
//        {
//            cheeseCount++;
//        }
//    }
//}
//string command;
//while ((command = Console.ReadLine()) != "danger")
//{ 

//    int newMouseRow = mouseRow;
//    int newMouseCol = mouseCol;

//    switch (command)
//    {
//        case "up":
//            newMouseRow--;
//            break;
//        case "down":
//            newMouseRow++;
//            break;
//        case "left":
//            newMouseCol--;
//            break;
//        case "right":
//            newMouseCol++;
//            break;
//    }

//    if (!IsInsideMatrix(newMouseRow, newMouseCol, rows, cols))
//    {
//        Console.WriteLine("No more cheese for tonight!");
//        break;
//    }

//    char newPosition = matrix[newMouseRow, newMouseCol];

//    if (newPosition == '@')
//    {
//        continue;
//    }
//    else if (newPosition == 'T')
//    {
//        matrix[mouseRow, mouseCol] = '*';
//        matrix[newMouseRow, newMouseCol] = 'M';
//        Console.WriteLine("Mouse is trapped!");
//        break;
//    }
//    else if (newPosition == 'C')
//    {
//        matrix[mouseRow, mouseCol] = '*';
//        matrix[newMouseRow, newMouseCol] = 'M';
//        cheeseCount--;

//        if (cheeseCount == 0)
//        {
//            Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
//            break;
//        }
//    }
//    else if (newPosition == '*')
//    {
//        matrix[mouseRow, mouseCol] = '*';
//        matrix[newMouseRow, newMouseCol] = 'M';
//    }

//    mouseRow = newMouseRow;
//    mouseCol = newMouseCol;
//}
//if ((command = Console.ReadLine()) == "danger")
//{
//    Console.WriteLine("Mouse will come back later!");
//    Environment.Exit(0);
//}
//PrintMatrix(matrix, rows, cols);


//    static bool IsInsideMatrix(int row, int col, int rows, int cols)
//{
//    return row >= 0 && row < rows && col >= 0 && col < cols;
//}

//static void PrintMatrix(char[,] matrix, int rows, int cols)
//{
//    for (int row = 0; row < rows; row++)
//    {
//        for (int col = 0; col < cols; col++)
//        {
//            Console.Write(matrix[row, col]);
//        }
//        Console.WriteLine();
//    }
//}

int[] sizeOfCupboard = Console.ReadLine()
    .Split(",", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int rows = sizeOfCupboard[0];
int cols = sizeOfCupboard[1];


char[,] field = new char[rows, cols];

string info = null;

int rowCount = 0;
int colCount = 0;

int cheeseCount = 0;

for (int i = 0; i < rows; i++)
{
    info = Console.ReadLine();

    for (int j = 0; j < cols; j++)
    {
        field[i, j] = info[j];

        if (info[j] == 'M')
        {
            rowCount = i;
            colCount = j;
        }
        else if (info[j] == 'C')
        {
            cheeseCount++;
        }
    }
}
field[rowCount, colCount] = '*';


string command = Console.ReadLine();

int foundCheeseCnt = 0;

while (command != "danger")
{
    if (command == "left")
    {
        colCount--;
        if (colCount < 0)
        {
            colCount++;
            Console.WriteLine("No more cheese for tonight!");
            field[rowCount, colCount] = 'M';
            break;
        }

        if (field[rowCount, colCount] == 'C')
        {
            foundCheeseCnt++;
            field[rowCount, colCount] = '*';

            if (foundCheeseCnt == cheeseCount)
            {
                Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                field[rowCount, colCount] = 'M';
                break;
            }
        }

        else if (field[rowCount, colCount] == 'T')
        {
            Console.WriteLine("Mouse is trapped!");
            field[rowCount, colCount] = 'M';
            break;
        }

        else if (field[rowCount, colCount] == '@')
        {
            colCount++;
        }
    }

    else if (command == "right")
    {
        colCount++;
        if (colCount >= cols)
        {
            colCount--;
            Console.WriteLine("No more cheese for tonight!");
            field[rowCount, colCount] = 'M';
            break;
        }

        if (field[rowCount, colCount] == 'C')
        {
            foundCheeseCnt++;
            field[rowCount, colCount] = '*';

            if (foundCheeseCnt == cheeseCount)
            {
                Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                field[rowCount, colCount] = 'M';
                break;
            }
        }

        else if (field[rowCount, colCount] == 'T')
        {
            Console.WriteLine("Mouse is trapped!");
            field[rowCount, colCount] = 'M';
            break;
        }

        else if (field[rowCount, colCount] == '@')
        {
            colCount--;
        }
    }

    else if (command == "down")
    {
        rowCount++;
        if (rowCount >= rows)
        {
            rowCount--;
            Console.WriteLine("No more cheese for tonight!");
            field[rowCount, colCount] = 'M';
            break;
        }

        if (field[rowCount, colCount] == 'C')
        {
            foundCheeseCnt++;
            field[rowCount, colCount] = '*';

            if (foundCheeseCnt == cheeseCount)
            {
                Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                field[rowCount, colCount] = 'M';
                break;
            }
        }

        else if (field[rowCount, colCount] == 'T')
        {
            Console.WriteLine("Mouse is trapped!");
            field[rowCount, colCount] = 'M';
            break;
        }

        else if (field[rowCount, colCount] == '@')
        {
            rowCount--;
        }
    }

    else if (command == "up")
    {
        rowCount--;
        if (rowCount < 0)
        {
            rowCount++;
            Console.WriteLine("No more cheese for tonight!");
            field[rowCount, colCount] = 'M';
            break;
        }

        if (field[rowCount, colCount] == 'C')
        {
            foundCheeseCnt++;
            field[rowCount, colCount] = '*';

            if (foundCheeseCnt == cheeseCount)
            {
                Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                field[rowCount, colCount] = 'M';
                break;
            }
        }

        else if (field[rowCount, colCount] == 'T')
        {
            Console.WriteLine("Mouse is trapped!");
            field[rowCount, colCount] = 'M';
            break;
        }

        else if (field[rowCount, colCount] == '@')
        {
            rowCount++;
        }

    }
    command = Console.ReadLine();
}


if (command == "danger")
{
    Console.WriteLine("Mouse will come back later!");
    Environment.Exit(0);
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(field[i, j]);
    }
    Console.WriteLine();
}