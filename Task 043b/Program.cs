// Вычислить площадь треугольника по координатам его вершин

Console.Clear();
Console.Write("Введите координаты вершин треугольника: ");
int[] coords = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

double a, b, c, p;
a = Math.Sqrt((coords[0] - coords[2]) * (coords[0] - coords[2]) + 
              (coords[1] - coords[3]) * (coords[1] - coords[3]));
b = Math.Sqrt((coords[0] - coords[4]) * (coords[0] - coords[4]) + 
              (coords[1] - coords[5]) * (coords[1] - coords[5]));
c = Math.Sqrt((coords[2] - coords[4]) * (coords[2] - coords[4]) + 
              (coords[3] - coords[5]) * (coords[3] - coords[5]));
p = (a + b + c) / 2.0;

double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
Console.WriteLine($"Площадь треугольника = {s}.");
