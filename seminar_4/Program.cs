// Напишите программу, которая принимает на вход число А и выдает сумму числе от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Сумма = " + GetSum(num));

// int GetSum(int number)
// {
//     int sum = 0;
//     int count = 0;

//     while (number>count)
//     {
//         count++;
//         sum+=count;
//     }
//     return sum;
// }

// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Число содержит " + GetCount(num) + " " + "цифр(ы)");

// int GetCount(int number)
// {
//     int count=0;
//     while(number>0)
//     {
//         count++;
//         number/=10;
//     }
//     return count;
// }

// Напишите программу, которая принимает на вход число А и выдает произведение числе от 1 до А.
// 4 -> 24
// 5 -> 120

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Произведение = " + GetProduct(num));

// int GetProduct(int number)
// {
//     int product = 1;
//     int count = 0;

//     while (number>count)
//     {
//         count++;
//         product*=count;
//     }
//     return product;
// }

// вариант 2

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Произведение = " + GetProduct(num));

// int GetProduct(int number)
// {
//     int product = 1;
    
//     for (int count=1; number>=count; count++)
//     {
//         product*=count;
//     }
//     return product;
// }

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// (1,0,1,1,0,1,0,0)

// int[] array = new int[8];

// // заполняем массив
// void FillArray(int[] collection)
// {
//     int Length = collection.Length;
//     int index = 0;
//     while(index<Length)
//     {
//         collection[index]=new Random().Next(0,2);
//         index++;
//     }
// }

// // выводим массив
// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while(position<count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }
// FillArray(array);
// PrintArray(array);

// ВАРИАНТ 2

int [] array = GetArray(8);
Console.WriteLine(string.Join(",",array));

int [] GetArray(int size)
{
    int [] result = new int [size];
    for (int i=0; i<size; i++)
    {
        result[i] = new Random().Next(0,2);
    }
    return result;
}
