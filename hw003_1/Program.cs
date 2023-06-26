// See https://aka.ms/new-console-template for more information

Console.WriteLine("Задание: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел");
Console.Write("Введите первое число: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (max < b) max = b;
if (c > max) max = c;
Console.WriteLine($"Максимальное число {max}");
