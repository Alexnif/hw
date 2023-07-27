// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;
using static System.Console;
Clear();
WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
int m = Get_int("Введите M: ");
int n = Get_int("Введите N: ");



WriteLine($"Результат функции Аккермана = {functionAkkerman(m,n)} ");

int functionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return functionAkkerman(m - 1, 1);
    else return functionAkkerman(m - 1, functionAkkerman(m, n - 1));
}

int Get_int(string message)
{
    Write(message);
    return int.Parse(ReadLine());
}