// Выводим сумму цифр в числе

Console.Clear();

Console.Write("Веедите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n, sum = 0;
while (m > 0)
{
    sum += m % 10;
    m /= 10;
}
Console.WriteLine($"Сумма цифр в числе {n} = {sum}.");
