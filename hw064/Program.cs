// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

using System;
using static System.Console;
Clear();
WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. ");
int count = Get_int("Введите N: ");
int numbers = 1;
WriteLine("Результат : ");
PrintNumber(count, numbers);

void PrintNumber(int n, int count)
{
    if (count > n) return;
    PrintNumber(n, count + 1);
    Console.Write(count + ", ");
}

int Get_int(string message)
{
    Write(message);
    return int.Parse(ReadLine());
}