// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 99)
    Console.Write("третьей цифры нет ");
else
{
while (num>999)
{
    num/=10;
}
    Console.Write($"третья цифра:  {num % 10}");
}