// Вычисление функции Аккермана (с помощью рекурсии)

int Func(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return Func(n - 1, 1);
    return Func(n - 1, Func(n, m - 1));
}

Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккерамана A({n},{m}) = {Func(n, m)}");

