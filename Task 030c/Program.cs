// Вводим размер массива, заполняем его случайными значениями и 
// сдвигаем элементы массива на заданное число элементов

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
        Console.Write(String.Format("{0,2}, ", arr[i]));
    Console.WriteLine(String.Format("{0,2}]", arr[arr.Length - 1]));
}

// ------ Функция возвращает "правильный" индекс массива -----
int NormIndex(int value, int n)
{
    return (value >= 0) ? (value % n) : (value % n) + n;
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
// удаляем лишние циклы сдвигов (для данного алгоритма необязательная операция)
shift = shift % n;

// непосредственно сдвиг
int start_index = 0, change_count = 0;
while (change_count < n)
{
    int cur_index = start_index;
    int next_index = NormIndex(cur_index - shift, n);
    int tmp = array[cur_index];
    while (next_index != start_index)
    {
        array[cur_index] = array[next_index];
        Console.Write($"{cur_index} <- ");  // для отладки
        change_count++;
        cur_index = next_index;
        next_index = NormIndex(next_index - shift, n);
    }
    array[cur_index] = tmp;
    Console.WriteLine($"{cur_index} <- {start_index}");  // для отладки
    start_index++;
    change_count++;
}

Console.Write("Массив после сдвига: ");
PrintArray(array);

Console.WriteLine("Сдвигаем в обратную сторону.");
start_index = 0; change_count = 0;
while (change_count < n)
{
    int cur_index = start_index;
    int next_index = NormIndex(cur_index + shift, n);
    int tmp = array[cur_index];
    while (next_index != start_index)
    {
        array[cur_index] = array[next_index];
        Console.Write($"{cur_index} <- ");  // для отладки
        change_count++;
        cur_index = next_index;
        next_index = NormIndex(next_index + shift, n);
    }
    array[cur_index] = tmp;
    Console.WriteLine($"{cur_index} <- {start_index}");  // для отладки
    start_index++;
    change_count++;
}
Console.Write("Массив после сдвига: ");
PrintArray(array);
