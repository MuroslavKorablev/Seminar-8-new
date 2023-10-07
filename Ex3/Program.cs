// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

//     Набор данных Частотный массив
//     { 1, 9, 9, 0, 2, 8, 0, 9 } 0 встречается 2 раза
//     1 встречается 1 раз
//     2 встречается 1 раз
//     8 встречается 1 раз
//     9 встречается 3 раза
//     1, 2, 3
//     4, 6, 1
//     2, 1, 6
//     1 встречается 3 раза
//     2 встречается 2 раз
//     3 встречается 1 раз
//     4 встречается 1 раз
//     6 встречается 2 раза

int rows = WorkWithUser("Введите кол-во строк: ");
int columns = WorkWithUser("Введите кол-во столбцов: ");
int[,] array = GetArray(rows, columns);
int foundCount = WorkWithUser("Введите искомое число: ");
PrintArray(array);
FoundCountNumbersInMatrix(array, foundCount);

int WorkWithUser(string message)
{
        System.Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,] GetArray(int row, int column)
{
    int[,] result = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = rnd.Next(1, 10);
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

void FoundCountNumbersInMatrix(int[,] inArray, int foundCount)
{
    int count = 0;
    for(int i = 0; i < inArray.GetLength(0); i++) // GetLength(0) для строчик
    { 
        for (int j = 0; j < inArray.GetLength(1); j++) //GetLength(1) для столбца
        {
            if (inArray[i,j] == foundCount)
            {
               count++;
            }
        }
    }
    System.Console.WriteLine($"Число {foundCount} встречается {count} раз.");
}

