// Программа вывода максимального и минимального из 2х чисел

Console.Write("Введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = a;

if (b > max) max = b;
if (b < min) min = b;

Console.WriteLine($"Минимальное из введенных чисел: {min}.");
Console.WriteLine($"Максимальное из введенных чисел: {max}.");
