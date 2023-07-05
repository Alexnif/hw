//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int GetNumber(string msg)
{
    Console.Write(msg);
    int rez = Convert.ToInt32(Console.ReadLine());
    return rez;
}

int x1, x2, y1, y2, z1, z2;
x1 = GetNumber("Введите х1 ");
x2 = GetNumber("Введите х2 ");
y1 = GetNumber("Введите y1 ");
y2 = GetNumber("Введите y2 ");
z1 = GetNumber("Введите z1 ");
z2 = GetNumber("Введите z2 ");
double rezult = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
Console.WriteLine($"Длина отрезка: {rezult} ");
