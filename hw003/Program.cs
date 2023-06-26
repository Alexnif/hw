// See https://aka.ms/new-console-template for more information

Console.WriteLine("Вводим два числа - выводим, какое число большее, а какое меньшее");
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"Первое число {a}  больше второго {b}.");
}
else if (a != b)
{
    Console.WriteLine($"Первое число {a}  меньше второго {b}.");
}
else
{
    Console.WriteLine($"Числа {a} и {b} равны");
}