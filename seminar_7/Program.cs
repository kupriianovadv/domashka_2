// Задайте двумерный массив размером m на n, заполненный случайными целыми числами.
// m=3 n=4
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// int rows = int.Parse(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix =new int[rows, columns];

// for(int i=0; i<matrix.GetLength(0); i++)
// {
//     for(int j=0; j<matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(0,11);
//         Console.Write(matrix[i,j] + "\t");
//     }
//     Console.WriteLine();
// }


// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: А = m+n.
// Выведите полученный массив на экран.
// m=3 n=4
// 0 1 2 3 
// 1 2 3 4 
// 2 3 4 5 

// int rows = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix =new int[rows, columns];

// for(int i=0; i<matrix.GetLength(0); i++)
// {
//     for(int j=0; j<matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = i+j;
//         Console.Write(matrix[i,j] + "\t");
//     }
//     Console.WriteLine();
// }

// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты.
// Выведите полученный массив на экран.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// int rows = int.Parse(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());

// double [,] matrix =new double[rows, columns];

//     for(int i=0; i<matrix.GetLength(0); i++)
// {
//     for(int j=0; j<matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(0,10);
       
//         if (i%2==0 && j%2==0)
//         {
//             matrix[i,j] = Math.Pow(matrix[i,j],2);
//         }
        
//         Console.Write(matrix[i,j] + "\t");
//     }
//     Console.WriteLine();
// }

// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали с индексами (0,0); (1,1) и тд

int rows = int.Parse(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix =new int[rows, columns];

int sum = 0;

    for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,10);
       
        if (i==j)
        {
           sum+=matrix[i,j];
        }
        
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("сумма = " + sum);
