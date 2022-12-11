// Находим произведение пар в массиве
// B[0] = A[0] * A[n-1]
// B[1] = A[1] * A[n-2] и т.д.

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

Console.Clear();
Console.Write("Введите размер массива: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[n1];
for (int i = 0; i < n1; i++)
    array1[i] = new Random().Next(0, 10);

Console.Write("Исходный массив: ");
PrintArray(array1);

int n2 = (n1 + 1) / 2;
int[] array2 = new int[n2];
for (int i = 0; i < n2; i++)
    array2[i] = array1[i] * array1[n1 - 1 - i];

Console.Write("Массив с произведением пар: ");
PrintArray(array2);
