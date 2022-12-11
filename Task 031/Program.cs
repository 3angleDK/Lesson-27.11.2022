// Заполняем массив случайными числами из диапазона [-9, 9]
// и вычисляем суммы отрицательных и положительных чисел

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
    array[i] = new Random().Next(-9, 10);

Console.Write("Исходный массив: ");
PrintArray(array);
Console.WriteLine();

int SumPositive = 0, SumNegative = 0;
for (int i = 0; i < n; i++)
    if (array[i] > 0)
        SumPositive += array[i];
    else    
        SumNegative += array[i];

Console.WriteLine($"Сумма положительных числе: {SumPositive}.");
Console.WriteLine($"Сумма отрицательных числе: {SumNegative}.");
