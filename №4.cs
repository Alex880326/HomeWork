﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7 
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
{
   System.Console.Write($"max {a}");
}
else if (b > a && b > c)
{
   System.Console.Write($"max {b}");
}
else 
{
    System.Console.Write($"max {c}");
}