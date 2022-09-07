// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int [] array = {3, 7, 22, 2, 78};
int size = array.Length;

int Max = 0;
int Min = 0;

for(int i=0;i<size;i++)
{
    if (array[i]>=Max)
    {
    Max=array[i];
    
    }
    if (array[i]<Max)

    {
    Min=array[i];
    
    }
}
Console.WriteLine("Максимальный элемент массива: " + Max);

Console.WriteLine("Минимальный элемент массива: " + Min);

Console.WriteLine("Разницу между максимальным и минимальным элементами массива: " + (Max-Min));