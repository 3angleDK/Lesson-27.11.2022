// Выдать название дня недели по его номеру
string[] DayOfWeek = new string[7] { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресение"};

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

int n;
do
{
    Console.Write("Веедите номер дня недели: ");
    n = Convert.ToInt32(Console.ReadLine());
} while (!NumberInInterval(n, 1, 7));

Console.Write($"День недели: {DayOfWeek[n - 1]}.");
