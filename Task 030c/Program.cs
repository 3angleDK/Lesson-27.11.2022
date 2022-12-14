// Вводим размер массива, заполняем его случайными значениями и 
// сдвигаем элементы массива на заданное число элементов
// Решаем через дополнительный массив

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
    int result = value % n;
    if (result < 0) result += n;
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
shift = shift % n;

int start_index = 0;
int change_count = 0, tmp1, tmp2;

while (change_count < n)
{
    int cur_index = start_index;
    int next_index = NormIndex(cur_index + shift, n);
    tmp1 = array[cur_index];
    do
    {
        tmp2 = array[next_index];
        array[next_index] = tmp1;
        change_count++;
        cur_index = next_index;
        tmp1 = tmp2;
        next_index = NormIndex(cur_index + shift, n);
    } while (cur_index != start_index);
    start_index++;
}

Console.Write("Массив после сдвига: ");
PrintArray(array);

