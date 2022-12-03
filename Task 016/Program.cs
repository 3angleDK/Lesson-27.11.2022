// Вводим 2 числа и проверяем, является ли одно число квадратом другого

int Min(int n1, int n2)
{
    if (n1 < n2) return n1;
    else return n2;
}

int Max(int n1, int n2)
{
    if (n1 > n2) return n1;
    else return n2;
}

Console.Clear();
Console.Write("Введите 1-е число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
if ((n1 == n2 * n2) || (n2 == n1 * n1))
    Console.WriteLine($"Число {Max(n1, n2)} является квадратом числа {Min(n1, n2)}.");
else
    Console.WriteLine($"Число {Max(n1, n2)} НЕ является квадратом числа {Min(n1, n2)}.");
