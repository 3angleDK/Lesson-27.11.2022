// Вывести все натуральные числа на отрезке [M, N] (с помощью рекурсии)

string GetNumbers(int start, int end)
{
    if (start == end) return end.ToString();
    return (start < end) ? GetNumbers(start, end - 1) + $", {end}": 
                           GetNumbers(start - 1, end) + $", {start}";
}

Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Числа: {GetNumbers(m, n)}");
