// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9;9]. 
// Найдите сумму отрицательных и положительных элементов массива.

// [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]
// сумма положительных = 29
// сумма отрицательных = -20

// int [] array = new int[12];
// int size = array.Length;

// int positiveSum = 0;
// int negativeSum = 0;

// for(int i=0;i<size;i++)
// {
//     array[i]=new Random().Next(-9,10);
//     if (array[i]>0)
//     {
//         positiveSum+=array[i];
//     }
//     else
//     {
//         negativeSum+=array[i];
//     }
// }
// Console.WriteLine("Сумма положительный чисел = " + positiveSum + " | Сумма отрицательных чисел = " +  negativeSum);
// Console.WriteLine(String.Join("; ",array));

// Найдите произведение пар чисел в одномерной массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишем в новом массиве.

// [1, ,2 ,3, 4, 5] -> 5 8 3 
// [6, 7, 3, 6] -> 36 21

// int [] inputArray = {6, 7, 3, 6};

// int [] resultArray = new int[inputArray.Length/2 + inputArray.Length%2];

// for(int i=0; i<resultArray.Length; i++)
// {
//     resultArray[i]=inputArray[i]*inputArray[inputArray.Length-1-i];
//     if(i==(inputArray.Length-1-i))
//     {
//         resultArray[i]=inputArray[i];
//     }
// }
// Console.WriteLine(String.Join(", ",resultArray));

// Напишите программу замены элементов массива: положительные элементы замените на соотвествующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int [] array = {-4, -8, 8, 2};
for(int i=0; i<array.Length; i++)
{
    array[i]*=-1;
}
Console.WriteLine(String.Join(", ",array));
