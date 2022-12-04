// вводим трёхзначное число и на выходе показываем вторую цифру этого числа

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
Console.Clear();
do
{
    Console.Write("Веедите трехзначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
} while (!NumberInInterval(n, 100, 999));

int m = n / 10 - (n / 100) * 10;
Console.WriteLine($"Вторая цифра числа: {m}.");
