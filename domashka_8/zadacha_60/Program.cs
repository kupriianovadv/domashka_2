// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

Console.WriteLine("Введите количество строк (X): ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (Y): ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность массива по оси Z: ");
int z = Convert.ToInt32(Console.ReadLine());

if (rows*columns*z > 90)
{
    Console.WriteLine("Ошибка");
}
else
{
    int count = 0;
    int[] matrixRandom = new int [90];
    for (int i=0; i<matrixRandom.Length-1; i++)
    {
        matrixRandom[i] = 10+i;
    }
    for(int i=0; i<matrixRandom.Length; i++)
    {
        int j = new Random().Next(matrixRandom.Length);
        int temp = matrixRandom[j];
        matrixRandom[j] = matrixRandom[i];
        matrixRandom[i] = temp;
    }

    int[,,] matrix3 = new int [rows, columns, z];

    for(int i=0; i<matrix3.GetLength(0); i++)
    {
        for(int j=0; j<matrix3.GetLength(1); j++)
        {
            for(int k=0; k<matrix3.GetLength(2); k++)
            {
                matrix3[i,j,k] = matrixRandom[count];
                Console.WriteLine($"{matrix3[i,j,k]} ({i},{j},{k})");
                count+=1;
            }
            Console.WriteLine();
        }
    
        
    }
}
