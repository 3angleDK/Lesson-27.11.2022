// По заданному номеру четверти выводим диапазон координат

// -- Функция определяет принадлежность числа заданному интервалу --
bool NumberInInterval(int value, int min, int max)
{
    if (value >= min && value <= max)
        return true;
    else 
    {
        Console.WriteLine($"Ошибка! Число должно находиться в интервале от {min} до {max}!");
        return false;
    }   
}
// ------------- Конец функции NumberInInterval -------------------

int n;
do
{
    Console.Write("Веедите № четверти: ");
    n = Convert.ToInt32(Console.ReadLine());
} while (!NumberInInterval(n, 1, 4));

if (n == 1)
    Console.WriteLine("x принадлежит интервалу (0, +бесконечность), y принадлежит интервалу (0, +бесконечность)");
else if (n == 2)
    Console.WriteLine("x принадлежит интервалу (-бесконечность, 0), y принадлежит интервалу (0, +бесконечность)");    
else if (n == 3)
    Console.WriteLine("x принадлежит интервалу (-бесконечность, 0), y принадлежит интервалу (-бесконечность, 0)");    
else if (n == 4)
    Console.WriteLine("x принадлежит интервалу (0, +бесконечность), y принадлежит интервалу (-бесконечность, 0)");    

/*
if (n == 1)
    Console.WriteLine("x ϵ (0, +∞), y ϵ (0, +∞)");
else if (n == 2)
    Console.WriteLine("x ϵ (-∞, 0), y ϵ (0, +∞)");    
else if (n == 3)
    Console.WriteLine("x ϵ (-∞, 0), y ϵ (-∞, 0)");    
else if (n == 4)
    Console.WriteLine("x ϵ (0, +∞), y ϵ (-∞, 0)");  */  