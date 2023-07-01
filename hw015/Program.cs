// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0 && num < 8)
{
    if (num == 7 || num == 6) Console.Write("это выходной ");

    else Console.Write("это рабочий день ");
}
else
{
    Console.WriteLine("число не является днем недели ");
}