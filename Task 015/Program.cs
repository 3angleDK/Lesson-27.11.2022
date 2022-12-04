// Принимаем на вход цифру, обозначающую день недели, 
// и проверяем, является ли этот день выходным.

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

string[] DayOfWeek = new string[7] { "понедельник", "вторник", "среда", "четверг", 
                                     "пятница", "суббота", "воскресение"};

Console.Clear();

int n;
do
{
    Console.Write("Веедите номер дня недели: ");
    n = Convert.ToInt32(Console.ReadLine());
} while (!NumberInInterval(n, 1, 7));

if ((n == 6) || (n == 7))
    Console.Write($"{DayOfWeek[n - 1]} - выходной.");
else
    Console.Write($"{DayOfWeek[n - 1]} - рабочий день.");
