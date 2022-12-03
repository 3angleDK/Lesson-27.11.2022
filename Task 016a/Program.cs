// Вводим последовательность натуральных чисел, завершающаяся числом 0. 
// Требуется определить значение второго по величине элемента в этой последовательности, 
// то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.

Console.Clear();

int FirstMax = 0;
int SecondMax = 0;

int n;
do
{
    Console.Write("Веедите число (0 - конец ввода): ");
    n = Convert.ToInt32(Console.ReadLine());
    if (n > FirstMax)
    {
        SecondMax = FirstMax;
        FirstMax = n;
    }
} while (n != 0);

Console.WriteLine($"Второе по величине число: {SecondMax}.");
