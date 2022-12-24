// В двумерном массиве поменять строки на столбцы

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

int[,] ReleaseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = i+1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    return matrix;
}

Console.Clear();
Console.Write("Введите размер квадратной матрицы: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[size, size];
InputMatrix(matrix);
Console.WriteLine("Начальный массив:");
PrintMatrix(matrix);
Console.WriteLine("Конечный массив:");
PrintMatrix(ReleaseMatrix(matrix));