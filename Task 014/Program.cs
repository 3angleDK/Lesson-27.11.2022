// вводим число и проверяем, кратно ли оно одновременно 7 и 23

Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if ((n % 7 == 0) && (n % 23 == 0))
    Console.WriteLine("Введенное чилсо кратно 7 и 23.");
else
    Console.WriteLine("Введенное чилсо НЕ кратно 7 и 23.");
