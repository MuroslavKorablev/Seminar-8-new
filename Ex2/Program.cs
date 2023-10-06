// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int rows = WorkWithUser("Введите кол-во строк: ");
int columns = WorkWithUser("Введите кол-во столбцов: ");
int minValue = WorkWithUser("Введите минимальное значение: ");
int maxValue = WorkWithUser("Введите максимальное значение: ");
int[,] array = GetArray(rows, columns, minValue, maxValue + 1);
if (rows != columns)
{
    System.Console.WriteLine("Замена строк на столбцы невозможна, так как матрица не квадратная.");
    return;
} 
PrintArray(array);
System.Console.WriteLine();
TransposeArray(array);
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

void TransposeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i+1; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
}