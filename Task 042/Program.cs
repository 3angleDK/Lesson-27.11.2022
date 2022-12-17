// Перевести число в двоичную форму

Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a;
string bin = String.Empty;
bin = "";

while (b > 0)
{
    bin = Convert.ToString(b % 2) + bin;
    b /= 2;    
}

Console.WriteLine($"Число {a} = {bin} в двоичной системе.");
