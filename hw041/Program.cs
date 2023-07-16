// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 

Console.Clear();
Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
Console.Write("Введите количестов чисел: ");
int lenght = Convert.ToInt32(Console.ReadLine());
int col=0;
for (int i = 0; i < lenght; i++)
{
Console.Write($"Введите {i+1} число:  ");
if (Convert.ToInt32(Console.ReadLine()) > 0) col++;
}
Console.WriteLine($"Количество чисел больше нуля:  {col}");
