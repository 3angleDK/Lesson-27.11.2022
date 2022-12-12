// Разбиваем массив на 2 массива: с четными и нечетными элементами
// и определяем каких элементов больше

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

Console.Clear();
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
    array[i] = new Random().Next(1, 32);

Console.Write("Исходный массив: ");
PrintArray(array);
Console.WriteLine();

int even_count = 0, odd_count = 0;
for (int i = 0; i < n; i++)
    if (array[i] % 2 == 0)
        even_count++;
    else
        odd_count++;

int[] even_array = new int[even_count];
int[] odd_array = new int[odd_count];
int even_i = 0, odd_i = 0;

for (int i = 0; i < n; i++)
    if (array[i] % 2 == 0)
    {
        even_array[even_i] = array[i];
        even_i++;
    }    
    else
    {
        odd_array[odd_i] = array[i];
        odd_i++;
    }    

Console.Write("Четные элементы: ");
PrintArray(even_array);
Console.Write("Нечетные элементы: ");
PrintArray(odd_array);

if (even_count == odd_count) 
    Console.WriteLine("Количество четных элементов = количеству нечетных (YES).");
else if (even_count > odd_count) 
    Console.WriteLine("Количество четных элементов > количества нечетных (YES).");
else
    Console.WriteLine("Количество четных элементов < количества нечетных (NO).");
