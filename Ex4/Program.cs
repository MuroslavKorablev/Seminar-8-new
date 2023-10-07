// Задача 59: Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int rows = WorkWithUser("Введите кол-во строк: ");
int columns = WorkWithUser("Введите кол-во столбцов: ");
int minValue = WorkWithUser("Введите минимальное значение: ");
int maxValue = WorkWithUser("Введите максимальное значение: ");
int[,] array = GetArray(rows, columns, minValue, maxValue + 1);
PrintArray(array);
System.Console.WriteLine();
int[,] newArray = DeleteMinRowsColnsOFIndex(array);
PrintArray(newArray);

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

int[,] DeleteMinRowsColnsOFIndex(int[,] array)
{
    int minValue = array[0, 0];
    
    // Находим минимальное значение
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minValue)
            {
                minValue = array[i, j];
            }
        }
    }

    HashSet<int> rowsToDelete = new HashSet<int>();
    HashSet<int> colsToDelete = new HashSet<int>();

    // Находим индексы минимальных значений
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == minValue)
            {
                rowsToDelete.Add(i);
                colsToDelete.Add(j);
            }
        }
    }

    // Создаем новый массив с учетом удаленных строк и столбцов
    int[,] newArray = new int[array.GetLength(0) - rowsToDelete.Count, array.GetLength(1) - colsToDelete.Count];
    int newRow = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (rowsToDelete.Contains(i)) continue;
        
        int newCol = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (colsToDelete.Contains(j)) continue;

            newArray[newRow, newCol] = array[i, j];
            newCol++;
        }
        newRow++;
    }

    return newArray;
}


