// Вывести все натуральные числа на отрезке [1, N] (с помощью рекурсии)

string GetNumbers(int n)
{
    if (n == 1) return "1";
    return GetNumbers(n-1) + $", {n}";
}

Console.Clear();
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Числа: {GetNumbers(n)}");
