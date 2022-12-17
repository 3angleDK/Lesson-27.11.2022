// Подсчитать количество положительных элементов в массиве

Console.Write("Введите элементы массива: ");
//double[] array = Console.ReadLine().Split(" ").Select(x => double.Parse(x)).ToArray();
double[] array = Console.ReadLine().Split(" ").Select(x => Convert.ToDouble(x)).ToArray();
Console.WriteLine($"Массив: {string.Join(" ", array)}");
int count = 0;

foreach (double element in array)
{
    if (element > 0.0) count++;
}

Console.WriteLine($"Количество положительных элементов в массиве = {count}");
