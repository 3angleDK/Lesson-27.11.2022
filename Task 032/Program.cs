// Меняем знак элементов массива

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
    array[i] = new Random().Next(-99, 100);

Console.Write("Исходный массив: ");
PrintArray(array);

for (int i = 0; i < n; i++)
    array[i] = -array[i]; 

Console.Write("Результат      : ");
PrintArray(array);
