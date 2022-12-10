// Вводим размер массива, заполняем его случайными значениями и 
// сдвигаем элементы массива на заданное число элементов

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}
Console.Clear();

// ------ Функция возвращает "правильный" индекс массива -----
int NormIndex(int value, int n)
{
    int result = value;
    if (value < 0)
        result = n + value;
    else if (value >= n)
        result = value - n;
    return result;
}
// ------ Конец функции NormIndex ------

Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
    array[i] = new Random().Next(0, 100);

Console.Write("Исходный массив    : ");
PrintArray(array);

Console.Write("Введите величину сдвига: ");
int shift = Convert.ToInt32(Console.ReadLine());
int tmp;

if (shift >= 0)
{
    for (int s = 0; s < shift; s++)
    {
        tmp = array[n - 1];
        for (int i = n - 2; i >= 0; i--)
            array[i + 1] = array[i];
        array[0] = tmp;
    }
}
else
{
    for (int s = 0; s > shift; s--)
    {
        tmp = array[0];
        for (int i = 1; i < n; i++)
            array[i - 1] = array[i];
        array[n - 1] = tmp;
    }
}

Console.Write("Массив после сдвига: ");
PrintArray(array);
