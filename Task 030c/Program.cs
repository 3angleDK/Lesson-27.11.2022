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

// ------ Функция возвращает "правильный" индекс массива -----
int NormIndex(int value, int n)
{
    int result = value % n;
    if (result < 0) result += n;
    return result;
}
// ------ Конец функции NormIndex ------

Console.Clear();
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

int start_index = 0, change_count = 0;
while (change_count < n)
{
    int next_index = NormIndex(start_index + shift, n);
    int tmp_cur, tmp_next;
    tmp_cur = array[start_index];
    Console.Write($"{start_index} ");
    do
    {
        tmp_next = array[next_index];
        array[next_index] = tmp_cur;
        Console.Write($"-> {next_index} ");
        change_count++;
        if (next_index == start_index) break;
        tmp_cur = tmp_next;
        next_index = NormIndex(next_index + shift, n);
    } while (true);
    start_index++;
    Console.WriteLine();
}

Console.Write("Массив после сдвига: ");
PrintArray(array);

Console.WriteLine("Сдвигаем в обратную сторону.");
start_index = 0;
change_count = 0;
while (change_count < n)
{
    int cur_index = start_index;
    int next_index = NormIndex(cur_index + shift, n);
    while (next_index != start_index)
    {
        int tmp = array[next_index];
        array[next_index] = array[cur_index];
        array[cur_index] = tmp;
        Console.Write($" {cur_index} <-> {next_index} |");
        change_count++;
        cur_index = next_index;
        next_index = NormIndex(next_index + shift, n);
    }
    start_index++;
    change_count++;
    Console.WriteLine();
}
Console.Write("Массив после сдвига: ");
PrintArray(array);
