// Вводим число N и выводим произведение чисел от 1 до N

Console.Clear();

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int res = 1;
for (int i = 2; i <= n; i++)
    res *= i;

Console.WriteLine($"Произведение чисел от 1 до {n} = {res}.");
