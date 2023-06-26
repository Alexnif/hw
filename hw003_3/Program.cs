// See https://aka.ms/new-console-template for more information

Console.WriteLine("Задание: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Четные числа: ");
for (int i = 1; i <= n; i++)
if (i%2 == 0) Console.Write($"{i}, ");
   
