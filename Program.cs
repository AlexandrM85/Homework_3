// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("--------------Задача №19.--------------");
Console.Write("Введите пятизначное число: ");
string num = (Console.ReadLine()!);

if (num.Length == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine("Данное число является палиндромом. ");
    }
    else
    {
        Console.WriteLine("Данное число не является палиндромом. ");
    }
}
else
{
    Console.WriteLine("Введено не пятизначное число. ");
}

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.
Console.WriteLine("--------------Задача №21.--------------");
Console.WriteLine("Введите координату x точки A: ");
double xa = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y точки A: ");
double ya = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату z точки A: ");
double za = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату x точки B: ");
double xb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y точки B: ");
double yb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату z точки B: ");
double zb = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));

Console.WriteLine($"Расстояние между точками {result:f2}");
