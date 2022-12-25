// Вводим число и возвращаем сумму его цифр (с помощью рекурсии)

int GetSum(int num)
{
    if (num < 10) return num;
    return GetSum(num / 10) + num % 10;
}

Console.Clear();
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {n} равна {GetSum(n)}");
