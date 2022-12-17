// Проверить существование треугольника по трем сторонам
Console.Clear();
Console.Write("Введите длину 1й стороны треуголника (a): ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите длину 2й стороны треуголника (b): ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите длину 3й стороны треуголника (c): ");
double c = Convert.ToDouble(Console.ReadLine());

if ((a + b > c) && (a + c > b) && (c + b > a))
    Console.WriteLine("Треугольник существует.");
else
    Console.WriteLine("Треугольник НЕ существует.");
