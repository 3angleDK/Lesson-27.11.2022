// Вводим число и выводим третью цифру введенного числа
// либо выводим что третьей цифры нет

Console.Clear();

Console.Write("Веедите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n;

if (n < 100)
    Console.WriteLine($"Третьей цифры у числа {n} нет.");
else 
{
    while (m > 999) m /= 10;
    Console.WriteLine($"Третья цифра у числа {n}: {m % 10}.");
}
