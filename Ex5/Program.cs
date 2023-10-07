// Задача 61: Вывести первые N строк треугольника
// Паскаля. Сделать вывод в виде равнобедренного
// треугольника

int[,] matrix = Triangle(5);
PrintTriangle(matrix);

int[,] Triangle(int num)
{
    int[,] triangle = new int[num, num];
    triangle[0, 0] = 1;
    for (int i = 0; i < num; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            if (j == 0 || i == j) triangle[i, j] = 1;
            else triangle[i, j] = triangle[i - 1, j] + triangle[i - 1, j - 1]; 
        }
    }
    return triangle;
}

void PrintTriangle(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] != 0) Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void Print2(int n)
{
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N - 1; j++)
        {
            System.Console.Write(" ");
        }
        int number = 1;
        for (int j = 0; j <= i; j++)
        {
            System.Console.Write(number + " ");
            number = number * (i - j) / (i + j)
        }
        System.Console.WriteLine();
    }
}