// Задача 61: Вывести первые N строк треугольника
// Паскаля. Сделать вывод в виде равнобедренного
// треугольника

// int[,] matrix = Triangle(5);
// PrintTriangle(matrix); 
PrintTrianglePascal(20);

// int[,] Triangle(int num)
// {
//     int[,] triangle = new int[num, num];
//     triangle[0, 0] = 1;
//     for (int i = 0; i < num; i++)
//     {
//         for (int j = 0; j <= i; j++)
//         {
//             if (j == 0 || i == j) triangle[i, j] = 1;
//             else triangle[i, j] = triangle[i - 1, j] + triangle[i - 1, j - 1]; 
//         }
//     }
//     return triangle;
// }

// void PrintTriangle(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(matrix[i,j] != 0) Console.Write(matrix[i,j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

void PrintTrianglePascal(int n)
{
    int maxLength = GetPascalNumber(n - 1, (n - 1) / 2).ToString().Length;

    for (int i = 0; i < n; i++)
    {
        // Вывод пробелов для выравнивания
        for (int j = 0; j < (n - i - 1) * (maxLength + 1) / 2; j++)
        {
            Console.Write(" ");
        }

        for (int j = 0; j <= i; j++)
        {
            // Вывод числа и пробела с выравниванием
            string numberStr = GetPascalNumber(i, j).ToString();
            Console.Write(numberStr.PadLeft(maxLength + 1));
        }
        Console.WriteLine();
    }
}

int GetPascalNumber(int row, int col)
{
    if (col == 0 || col == row)
    {
        return 1;
    }
    else
    {
        return GetPascalNumber(row - 1, col - 1) + GetPascalNumber(row - 1, col);
    }
}




