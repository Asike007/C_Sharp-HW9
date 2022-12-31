// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine(Sum(5, 10));
int Sum(int m, int n)
{
    if (n > m)
    {
        if (n > m) return n + Sum(m, n - 1);
        else return n;
    }
    if (m > n)
    {
        if (m > n) return m + Sum(m - 1, n);
        else return m;
    }
    return m;
}