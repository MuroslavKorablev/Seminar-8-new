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
int minValue = WorkWithUser("Введите минимальное значение: ");
int maxValue = WorkWithUser("Введите максимальное значение: ");
int[,] array = GetArray(rows, columns, minValue, maxValue + 1);
if (rows != columns)
{
    System.Console.WriteLine("Замена строк на столбцы невозможна, так как матрица не квадратная.");
    return;
} 


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
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = rnd.Next(minValue, maxValue);
        }
    }
    return result;
}