// Заполнить двумерный массив случайными вещественными числами
double FloatRnd(double min, double max, int digits)
{
    return Math.Round(new Random().NextDouble() * (max - min) + min, digits);
}

void InputMatrix(double[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            matrix[row, col] = FloatRnd(-100.0, 100.0, 3);
        }
        Console.WriteLine();
    }
}

void OutputMatrix(double[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write($"{matrix[row, col]}   \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Trim().Split(" ").Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
InputMatrix(matrix);
OutputMatrix(matrix);
