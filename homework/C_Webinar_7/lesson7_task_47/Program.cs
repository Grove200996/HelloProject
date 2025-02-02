﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9



double[,] CreateMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = Math.Round((rnd.NextDouble() * 100), 2);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],6}, ");
            else Console.Write($"{matrix[i, j],6}");
        }

        Console.WriteLine("]");
    }
}


Console.Write("Введите количество строк и столбцов через запятую: ");
string values = Console.ReadLine();
string[] val = values.Split(',');
int m = Convert.ToInt32(val[0]);
int n = Convert.ToInt32(val[1]);

if (m > 0 && n > 0)
{
    double[,] matrix = CreateMatrix(m,n);
    PrintMatrix(matrix);
}
else Console.WriteLine("Введены некорректные данные.");