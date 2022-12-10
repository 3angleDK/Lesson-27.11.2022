// Выводим количество цифр в числе

Console.Clear();

Console.Write("Веедите число: ");
int n = Convert.ToInt32(Console.ReadLine());
// вариант решения в лоб
int m = n, count = 0;
while (m > 0)
{
    ++count;
    m /= 10;
}
Console.WriteLine($"В числе {n} {count} цифр(а/ы).");
Console.WriteLine();
    
// Вариант решения через десятичный логарифм
count = Convert.ToInt32(Math.Log10(n));
Console.WriteLine($"В числе {n} {count} цифр(а/ы).");
