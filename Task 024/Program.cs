// Вводим число N и выводим сумму чисел от 1 до N

Console.Clear();

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
// вариант решения в лоб
int sum = 0;
for (int i = 1; i <= n; i++)
    sum += i;

Console.WriteLine($"Сумма чисел от 1 до {n} = {sum}.");
Console.WriteLine();

// Вариант решения по формуле суммы арифметической прогрессии
sum = n * (n + 1) / 2;
Console.WriteLine($"Сумма чисел от 1 до {n} = {sum}.");
