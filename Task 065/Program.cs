// Вывести все натуральные числа на отрезке [M, N] (с помощью рекурсии)

string GetNumbers(int m, int n)
{
    if (n == m) return n.ToString();
    return (m < n) ? GetNumbers(m, n - 1) + $", {n}": 
                     GetNumbers(m, n + 1) + $", {n}";
}

Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Числа: {GetNumbers(m, n)}");
