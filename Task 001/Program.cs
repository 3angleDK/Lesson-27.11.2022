// Вводим 2 числа и проверяем, является ли 1-е число квадратом второго
Console.Clear();
Console.Write("Введите 1-е число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 == n2 * n2)
    Console.WriteLine($"Число {n1} является квадратом числа {n2}.");
else
    Console.WriteLine($"Число {n1} не является квадратом числа {n2}.");
