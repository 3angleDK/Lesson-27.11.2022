// Подсчет четных элементов массива

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
    array[i] = new Random().Next(100, 1000);

Console.Write("Исходный массив: ");
PrintArray(array);

int count = 0;
for (int i = 0; i < n; i++)
    if (array[i] % 2 == 0) 
        count++;

Console.WriteLine($"В массиве {count} четных элемент(а/ов).");
