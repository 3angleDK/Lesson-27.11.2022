// Гипотеза Гольдбаха
// Представляем четное число в виде суммы 2х простых чисел

bool IsNumberCorrect(int value)
{
    if ((value % 2 == 0) && (value >= 4) && (value <= 998))
        return true;
    else
    {
        Console.WriteLine("ОШИБКА! Число должно быть чётным и на интервале [4..998].");
        return false;
    }    
}

bool IsNumberPrime(int value)
{
    for (int i = 2; i <= value / 2; i++)
        if (value % i == 0)
            return false;
    return true;
}

Console.Clear();
int n, a , b = 0;
do
{
    Console.Write("Введите четное число на интервале [4..998]: ");
    n = Convert.ToInt32(Console.ReadLine());
} while (!IsNumberCorrect(n));

for (a = 2; a < n; a++)
{
    if (IsNumberPrime(a))
    {
        b = n - a;
        if (IsNumberPrime(b)) break;
    }
}

Console.WriteLine($"Число {n} представимо в виде суммы простых чисел {a} и {b}.");
