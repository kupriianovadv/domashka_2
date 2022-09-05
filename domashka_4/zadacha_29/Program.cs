// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];

// заполняем массив
void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while(index<Length)
    {
        collection[index]=new Random().Next(0,2);
        index++;
    }
}

// выводим массив
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
FillArray(array);
PrintArray(array);