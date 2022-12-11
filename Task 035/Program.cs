// Определяем количество элементов массива лежащих на отрезке [10, 99]

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
    array[i] = new Random().Next(0, 200);

Console.Write("Исходный массив: ");
PrintArray(array);

int count = 0;
for (int i = 0; i < n; i++)
    if ((array[i] >= 10) && (array[i] <= 100))
        count++;

Console.WriteLine($"Количество элементов лежащих на отрезке [10, 99] = {count}.");
