// Вводим размер массива, заполняем его случайными значениями и 
// сдвигаем элементы массива на заданное число элементов
// решение через последовательный сдвиг на 1 элемент

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

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
// удаляем лишние циклы сдвигов
shift = shift % n;
// циклический сдвиг влево на i элементов, равноценен сдвигу вправо на (n-i) элементов
if (shift < 0) shift += n;

for (int s = 0; s < shift; s++)
{
    int tmp = array[n - 1];
    for (int i = n - 2; i >= 0; i--)
        array[i + 1] = array[i];
    array[0] = tmp;
}

Console.Write("Массив после сдвига: ");
PrintArray(array);
