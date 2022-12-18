// Число несовпадающих пикселей изображения

void InputImage(int[,] Image)
{
    for (int row = 0; row < Image.GetLength(0); row++)
        for (int col = 0; col < Image.GetLength(1); col++)
            Image[row, col] = new Random().Next(0, 2);
}

void OutputImage(int[,] Image)
{
    for (int row = 0; row < Image.GetLength(0); row++)
    {
        for (int col = 0; col < Image.GetLength(1); col++)
            Console.Write($"{Image[row, col]}\t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры изображения: ");
int[] size = Console.ReadLine().Trim().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] Image1 = new int[size[0], size[1]];
InputImage(Image1);
Console.WriteLine("Первое изображение:");
OutputImage(Image1);

int[,] Image2 = new int[size[0], size[1]];
InputImage(Image2);
Console.WriteLine("Второе изображение:");
OutputImage(Image2);

int count = 0;
for (int row = 0; row < Image1.GetLength(0); row++)
{
    for (int col = 0; col < Image1.GetLength(1); col++)
    {
        if (Image1[row, col] != Image2[row, col])
        {
            count++;
        }
    }
}

Console.WriteLine($"Число несопадающих пикселей = {count}.");

