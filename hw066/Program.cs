// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


using System;
using static System.Console;
Clear();
WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
int m = Get_int("Введите M: ");
int n = Get_int("Введите N: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}
WriteLine("Результат : ");
PrintSumm(m, n, temp = 0);

void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов = {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ);
}

int Get_int(string message)
{
    Write(message);
    return int.Parse(ReadLine());
}