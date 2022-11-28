// Программа вывода всех четных чисел от 1 до N

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int step = 1;
if (n <= 0) step = -1;
for (int i = 1; Math.Abs(i) <= Math.Abs(n); i += step)
    if (i % 2 == 0)
        Console.Write($"{i} ");
