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
    if (result < 0) return result + n;
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
// удаляем лишние циклы сдвигов
shift = shift % n;

int[] shifted_array = new int[n];

for (int i = 0; i < n; i++)
    shifted_array[NormIndex(i + shift, n)] = array[i];

Console.Write("Массив после сдвига: ");
PrintArray(shifted_array);
