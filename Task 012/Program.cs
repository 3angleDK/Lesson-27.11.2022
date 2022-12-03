// Вводим 2 числа и проверяем, является ли второе число кратным первому. 
// Если 2е число не кратно числу 1му, то выводим остаток от деления.

Console.Clear();

Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n % m == 0)
    Console.WriteLine("Кратно");
else
    Console.WriteLine($"Не кратно, остаток {n % m}");

