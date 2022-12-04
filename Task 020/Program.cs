﻿// Вычисляем расстояние между 2мя точками на плоскости

Console.Clear();

double x1, y1, x2, y2;

Console.Write("Веедите координату X 1-й точки: ");
x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Веедите координату Y 1-й точки: ");
y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Веедите координату X 2-й точки: ");
x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Веедите координату Y 2-й точки: ");
y2 = Convert.ToDouble(Console.ReadLine());

double d = Math.Round(Math.Sqrt((x2 - x1) * (x2 - x1) +
                                (y2 - y1) * (y2 - y1)), 3);

Console.WriteLine($"Расстояние между точками: {d}");
