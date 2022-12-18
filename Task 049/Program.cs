// Заменить в двумерном массиве элементы, у которых оба индекса нечетные,
// на их квадраты

void InputMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
        for (int col = 0; col < matrix.GetLength(1); col++)
            matrix[row, col] = new Random().Next(-10, 11);
}

void OutputMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
            Console.Write($"{matrix[row, col]}\t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Trim().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Исходная матрица:");
OutputMatrix(matrix);

int[,] result = new int[size[0], size[1]];

for (int row = 0; row < result.GetLength(0); row++)
{
    for (int col = 0; col < result.GetLength(1); col++)
        if (row % 2 == 1 && col % 2 ==1)
            result[row,col] = matrix[row,col] * matrix[row,col];
        else
            result[row,col] = matrix[row,col];
}

Console.WriteLine("Конечная матрица:");
OutputMatrix(result);

