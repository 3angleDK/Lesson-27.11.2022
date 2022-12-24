// Составить частотный словарь элементов двумерного массива.

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

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив:");
PrintMatrix(matrix);

Dictionary<int, int> freq = new Dictionary<int, int>();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        if (!freq.ContainsKey(matrix[i, j]))
            freq.Add(matrix[i, j], 1);
        else
            freq[matrix[i, j]]++;
}

foreach(var el in freq)
    Console.WriteLine($"Элемент {el.Key} встречается {el.Value} раз.");

// Альтернативное решение
// bool CheckNumberInArray(int[] array, int number)
// {
//     foreach (int element in array)
//     {
//         if (element == number)
//             return false;
//     }
//     return true;
// }


// int InputMatrix(int[,] matrix, int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 11); // [-10, 10]
//             if (CheckNumberInArray(array, matrix[i, j]) == true)
//             {
//                 array[count] = matrix[i, j];
//                 count++;
//             }
//         }
//     }
//     return count;
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


// void ReleaseMatrix(int[,] matrix, int[] array, int count)
// {
//     for (int k = 0; k < count; k++)
//     {
//         int countNumbers = 1;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = i + 1; j < matrix.GetLength(1); j++)
//             {
//                 if (array[k] == matrix[i, j])
//                     countNumbers++;
//             }
//         }
//         Console.WriteLine($"{array[k]} встречается {countNumbers} раз");
//     }
// }


// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// int[] array = new int[size[0] * size[1]];
// Console.WriteLine("Начальный массив:");
// int count = InputMatrix(matrix, array);
// PrintMatrix(matrix);
// ReleaseMatrix(matrix, array, count);