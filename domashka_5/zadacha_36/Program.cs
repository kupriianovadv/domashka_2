// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array = new int[4];
int size = array.Length;

int SumNechet = 0;
    
for(int i=0;i<size;i++)
{
   array[i]=new Random().Next(100,1000);
   if (array[i]%2>0)
    {
    SumNechet+=array[i];
    }
}

Console.WriteLine(String.Join("; ",array));
Console.WriteLine("Количество четных чисел в массиве = " + SumNechet);
