// Поэлементное копирование массива

Console.Clear();
Console.Write("Введите элементы массива: ");
int[] a = Console.ReadLine().Trim().Split(" ").Select(x => Convert.ToInt32(x)).ToArray();
int[] b = new int[a.Length];

for (int i = 0; i < a.Length; i++)
    b[i] = a[i];

Console.WriteLine($"Исходный массив: {string.Join(", ", a)}");
Console.WriteLine($"Конечный массив: {string.Join(", ", b)}");
