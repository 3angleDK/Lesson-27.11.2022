// Найти точку пересечения 2х прямых

Console.Clear();
Console.Write("Введите параметры (k, b) первой прямой: ");
double[] line1 = Console.ReadLine().Split(" ").Select(x => double.Parse(x)).ToArray();
Console.Write("Введите параметры (k, b) второй прямой: ");
double[] line2 = Console.ReadLine().Split(" ").Select(x => double.Parse(x)).ToArray();

double x, y;
if (Math.Abs(line1[0] - line2[0]) > 1e-6)
{
    x = (line2[1] - line1[1]) / (line1[0] - line2[0]);
    y = line1[0] * x + line1[1];
    Console.WriteLine($"Точка перечения 2х прямых ({x}, {y}).");
}
else 
{
    Console.WriteLine("Прямые параллельны.");
}
