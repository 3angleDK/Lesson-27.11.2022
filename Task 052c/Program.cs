// Заполнить матрицу последовательными числами по диагонали

int Min(int a, int b) => (a < b) ? a : b;
int Max(int a, int b) => (a > b) ? a : b;

void FillMatrix(int[,] matrix)
{
    int value = 0;
    int row_count = matrix.GetLength(0);
    int col_count = matrix.GetLength(1);
    int diag_count = row_count + col_count - 1;
    for (int i = 0; i < diag_count; i++)
    {
        int row = Max(0, i - col_count + 1);
        int col = Min(col_count - 1, i);
        while (row < row_count && col >= 0)
        {
            matrix[row, col] = value;
            value++;
            row++;
            col--;
        }
    }
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
FillMatrix(matrix);
Console.WriteLine("Матрица:");
OutputMatrix(matrix);
