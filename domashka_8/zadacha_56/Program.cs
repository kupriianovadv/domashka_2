﻿// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int temp = int.MaxValue;

Console.WriteLine();
Console.WriteLine("Массив: ");

int [,] matrix =new int[rows, columns];

if (rows != columns)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(11);
            Console.Write(matrix[i,j] + "\t");
        }
    
        Console.WriteLine();
    }
    Console.WriteLine("  ");

    int k = 0;

    for (int i = 0; i<matrix.GetLength(0); i++)
    {
        int sum  = 0;
        for (int j = 0; j<matrix.GetLength(1); j++)
        {
            sum+=matrix[i,j];
        }
        Console.WriteLine($"Сумма элементов строки {i+1} = {sum}");
        
        if (temp>sum)
        {
            temp = sum;
            k = i;
        }
    }
        Console.WriteLine($"Номер строки с наименьшим количеством элементов {k+1}");
}
else{Console.WriteLine("Массив не прямоугольный");}

