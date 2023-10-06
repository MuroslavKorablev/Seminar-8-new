// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.
int rows = WorkWithUser("Введите кол-во строк: ");
int columns = WorkWithUser("Введите кол-во столбцов: ");
int minValue = WorkWithUser("Введите минимальное значение: ");
int maxValue = WorkWithUser("Введите максимальное значение: ");
int[,] array = GetArray(rows, columns, minValue, maxValue + 1);
PrintArray(array);
System.Console.WriteLine();
ReverseRowEndpoints(array);
PrintArray(array);

int WorkWithUser(string message)
{
        System.Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,] GetArray(int row, int column, int minValue, int maxValue)
{
    int[,] result = new int[row, column];
    Random rnd = new Random();
    for(int i = 0; i < row; i++)
    { 
        for (int j = 0; j < column; j++)
        {
            result[i, j] = rnd.Next(minValue, maxValue); 
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++) // GetLength(0) для строчик
    { 
        for (int j = 0; j < inArray.GetLength(1); j++) //GetLength(1) для столбца
        {
            System.Console.Write($"{inArray[i, j]} "); 
        }
        System.Console.WriteLine();
    }
}

void ReverseRowEndpoints(int[,] array)
{
    int rows = array.GetLength(0);
     int columns = array.GetLength(1);
    for (int j = 0; j < columns; j++)
    {
        int temp = array[0, j];
        array[0, j] = array[rows - 1, j];
        array[rows - 1, j] = temp;
    }
}