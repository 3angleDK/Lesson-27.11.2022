// Заменяем в массиве все максимальные элементы на минимальные

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int max = 0, min = 1001;
int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i + 1} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > max)
        max = array[i];

    if (array[i] < min)
        min = array[i];
}
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
for (int i = 0; i < array.Length; i++)
    if (array[i] == max) array[i] = min;

Console.WriteLine($"Результирующий массив: [{string.Join(", ", array)}]");

