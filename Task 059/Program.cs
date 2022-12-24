// В двумерном массиве удалить строку и столбец, на пересечении 
// которых разсположен минимальный элемент

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


void PrintReleaseMatrix(int[,] matrix, int iMin, int jMin)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != iMin)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (j != jMin)
                    Console.Write($"{matrix[i, j]} \t");
            Console.WriteLine();
        }
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив:");
PrintMatrix(matrix);

int iMin = 0, jMin = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
    for (int j = 0; j < matrix.GetLength(1); j++)
        if (matrix[i,j] < matrix[iMin,jMin])
        {
            iMin = i;
            jMin = j;
        }

Console.WriteLine("Конечный массив:");
PrintReleaseMatrix(matrix, iMin, jMin);

// Альтернативный вариант
// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(-10, 11); // [1, 10]
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }

// void DictionaryMatrix(int[,] matrix)
// {
//     int minRow = 0, minColumn = 0, minValue = matrix[0, 0];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] <= minValue)
//             {
//                 minValue = matrix[i, j];
//                 minColumn = j;
//                 minRow = i;
//             }
//         }
//     }
//     Console.WriteLine($"Минимальный элемент {minValue}({minRow + 1}, {minColumn + 1})");
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         if (minRow != i)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 if (minColumn != j)
//                     Console.Write($"{matrix[i, j]} \t");
//             }
//         Console.WriteLine();
//         }
//     }
// }


// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// Console.WriteLine("Начальный массив:");
// InputMatrix(matrix);
// PrintMatrix(matrix);
// DictionaryMatrix(matrix);