// Вывести все перестановки символов строки

void perm(char[] s, int pos)
{
    if (pos == s.Length - 1)
        Console.WriteLine(s);
    else
    {
        perm(s, pos + 1);
        for (int i = pos + 1; i < s.Length; ++i)
        {
            char tmp = s[pos];
            s[pos] = s[i];
            s[i] = tmp;
            perm(s, pos + 1);
            tmp = s[pos];
            s[pos] = s[i];
            s[i] = tmp;
        }
    }
}

Console.Clear();
Console.Write("Введите строку: ");
char[] s = Console.ReadLine().ToCharArray();

perm(s, 0);
