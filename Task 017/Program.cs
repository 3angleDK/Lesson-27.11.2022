// Вводим координаты точки X и Y и выводим № четверти
// X <> 0, Y <> 0

// -- Функция определяет корректность координаты (<> 0) --
bool CoordCorrect(double value)
{
    if (value != 0.0)
        return true;
    else 
    {
        Console.WriteLine($"Ошибка! Координата не должна быть равна 0!");
        return false;
    }   
}
// ------------- Конец функции NumberInInterval -------------------

double x, y;
do
{
    Console.Write("Веедите координату X: ");
    x = Convert.ToDouble(Console.ReadLine());
} while (!CoordCorrect(x));
do
{
    Console.Write("Веедите координату Y: ");
    y = Convert.ToDouble(Console.ReadLine());
} while (!CoordCorrect(y));
 int n;
if (y > 0.0)
    if (x > 0.0) n = 1;
    else n = 2;
else    
    if (x > 0.0) n = 4;
    else n = 3;

Console.WriteLine($"Точка находится в {n}-й четверти!");
