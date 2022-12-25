// Возвести число A в степень B (с помощью рекурсии)

int Power(int num, int degree)
{
    if (degree == 0) return 1;
    return Power(num, degree-1) * num;
}

Console.Clear();
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{a} в степени {b} = {Power(a,b)}");

