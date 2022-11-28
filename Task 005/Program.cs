// Выводим целые числа на интервале [-N...N]

Console.Write("Веедите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = -n; i <= n; i++)
    Console.Write($"{i} ");

    