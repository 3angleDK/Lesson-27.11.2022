// Поиск элемента массива

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

int IndexOf(int[] array, int value)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == value)
            return i;
    return -1;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
    array[i] = new Random().Next(-99, 100);

Console.Write("Исходный массив: ");
PrintArray(array);

Console.Write("Введите искомый элемент: ");
int v = Convert.ToInt32(Console.ReadLine());

int index = IndexOf(array, v);
if (index>= 0) 
    Console.Write($"Элемент {v} находится в {index}-й позиции.");
else 
    Console.Write($"Элемент {v} в массиве отсутствует.");

