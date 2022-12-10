// Вводим размер массива из заполняем его нулями и единицами в случайном порядке

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
    array[i] = new Random().Next(0, 2);

Console.WriteLine();
Console.Write("Массив: ");
PrintArray(array);