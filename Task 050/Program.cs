// Вывести элемент двумерного массива по его индексам

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

Console.Write("Введите индексы матрицы: ");
int[] pos = Console.ReadLine().Trim().Split(" ").Select(x => int.Parse(x)).ToArray();

if (pos[0] >= matrix.GetLength(0) || pos[1] >= matrix.GetLength(1))
{
    Console.WriteLine($"Элемента A[{pos[0]}, {pos[1]}] не существует.");
}
else 
{
    Console.WriteLine($"Элемент A[{pos[0]}, {pos[1]}] = {matrix[pos[0], pos[1]]}.");
}

