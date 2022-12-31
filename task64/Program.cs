// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

void NumbersFromMtoN(int m, int n)
{
    if (n > m) NumbersFromMtoN(m, n - 1);
    Console.Write($"{n} ");
    if (m > n) NumbersFromMtoN(m, n + 1);
}
NumbersFromMtoN(1, 5);
Console.WriteLine();

// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void Numbers(int n)
{
    Console.Write(n + " ");
    if (n > 1) Numbers(n - 1);
}
Numbers(5);
