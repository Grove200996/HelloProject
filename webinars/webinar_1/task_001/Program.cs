﻿// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;
Console.WriteLine($"square of number {num} = {result}");
