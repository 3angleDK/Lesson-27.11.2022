// Находим максимальную сумму 3х соседних элементов массива

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

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i + 1} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int max = 0;
int sum;
for (int i = 0; i < array.Length; i++)
{
    sum = array[NormIndex(i - 1, n)] +
          array[NormIndex(i , n)] +
          array[NormIndex(i + 1, n)];
    if (sum > max) max = sum;
}

Console.WriteLine($"Максимальная сумма 3х соседних элементов: {max}");
