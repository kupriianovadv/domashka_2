// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// Console.WriteLine("Массив: ");

// int [,] matrix =new int[rows, columns];

// for(int i=0; i<matrix.GetLength(0); i++)
// {
//     for(int j=0; j<matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(0,10);
//         Console.Write(matrix[i,j] + "\t");
//     }
    
//     Console.WriteLine();
// }

// int [] matrix1 = new int[matrix.GetLength(1)];

// for (int k=0; k<matrix.GetLength(1); k++)
// {
//     matrix1[k] = matrix[0,k];
//     matrix[0,k] = matrix[matrix.GetLength(0)-1,k];
//     matrix[matrix.GetLength(0)-1,k] = matrix1[k];
// }

// Console.WriteLine("Новый массив: ");

// for(int i=0; i<matrix.GetLength(0); i++)
// {
//     for(int j=0; j<matrix.GetLength(1); j++)
//     {
//         Console.Write(matrix[i,j] + "\t");
//     }
    
//     Console.WriteLine();
// }


// Задайте двумерный массив. Напишите программу, которая заменяетстроки на столбцы. 
// В случае, если  это невозможно, программа должна вывести сообщение для пользователя.

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// Console.WriteLine("Массив: ");

// int [,] matrix =new int[rows, columns];

// for(int i=0; i<matrix.GetLength(0); i++)
// {
//     for(int j=0; j<matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(0,10);
//         Console.Write(matrix[i,j] + "\t");
//     }
    
//     Console.WriteLine();
// }
// Console.WriteLine("Новый массив: ");

// if (matrix.GetLength(0) == matrix.GetLength(1))
// {
//     for(int i=0; i<matrix.GetLength(0); i++)
//     {
//         for(int j=0; j<matrix.GetLength(1); j++)
//         {   
//             Console.Write(matrix[j,i] + "\t");
//         }
//         Console.WriteLine();
//     }  
// }
// else Console.WriteLine("невозможно сделать замену");

// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// Console.WriteLine("Массив: ");

// int [,] matrix =new int[rows, columns];
// int minValue = int.MaxValue;
// int minIndexRows = 0;
// int minIndexColumns = 0;

// for(int i=0; i<matrix.GetLength(0); i++)
// {
//     for(int j=0; j<matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(11);
//         Console.Write(matrix[i,j] + "\t");
//         if (minValue>matrix[i,j])

//         {
//             minValue = matrix[i,j];
//             minIndexRows = i;
//             minIndexColumns = j;
//         }
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Минимум: " + minValue);
// System.Console.WriteLine("Результат:");

// for (int i = 0; i<rows; i++)
// {
//     if (i != minIndexRows)
//     {
//         for (int j = 0; j<columns; j++)
//         {
//             if (j != minIndexColumns)
//             {
//                 Console.Write(matrix[i,j] + "\t");
//             }
//         }
//         System.Console.WriteLine();
//     }
// }


