﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Массив: ");

int [,] matrix =new int[rows, columns];

for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,11);
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите номер строки элемента: ");
int rowNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента: ");
int columnNum = Convert.ToInt32(Console.ReadLine());

if(rows < rowNum || columns < columnNum)
{
  Console.WriteLine("Такой позиции в массиве нет");
}
else
{
    Console.WriteLine("Значение запрашиваемого элемента: " + matrix[rowNum-1, columnNum-1]);
}