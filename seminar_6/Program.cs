// Задача 39. Напишите программу, которая перевернет одномерный массив.
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int [] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(", ", array));

// ReversArray(array);
// Console.WriteLine(String.Join(", ", array));

// int [] GetArray (int size, int MinValue, int MaxValue)
// {
//     int [] res = new int [size];
//     for(int i=0; i<size; i++)
//     {
//         res[i] = new Random().Next(MinValue, MaxValue);
//     }
//     return res;
// }

// void ReversArray (int [] InArray)
// {
//     for(int i=0; i<InArray.Length/2; i++)
//     {
//         int k = InArray[i];
//         InArray[i] = InArray[InArray.Length-1-i];
//         InArray[InArray.Length-1-i] = k;
//     }
// }

// Задача 40. Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длинны.
// каждая сторона треугольника меньше суммы двух других сторон.

// Console.WriteLine("Введите стороны треугольника(а, b, c): ");
// double num1 = Convert.ToDouble(Console.ReadLine());
// double num2 = Convert.ToDouble(Console.ReadLine());
// double num3 = Convert.ToDouble(Console.ReadLine());

// CheckTriangle(num1, num2, num3);

// void CheckTriangle(double a, double b, double c)
// {
//     if(a<(b+c) && b<(c+a) && c<(a+b))
//     {
//         Console.WriteLine("Может существовать треугольник со сторонами указанной длины");
//     }
//     else
//     {
//         Console.WriteLine("Не может быть треугольника");
//     }
// }

// Задача 41. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.WriteLine("Введите десятичное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// ConvertNum(num);

// void ConvertNum(int number)
// {
//     String result = "";
//     while (number>0)
//     {
//         result = number%2+result;
//         number/=2;
//     }
//     Console.WriteLine(result);
// }

// Задача 44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 ->  0 1 1 2 3 
// Если N = 3 ->  0 1 1
// Если N = 7 ->  0 1 1 2 3 5 8

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int firstN = 0;
int secondN = 1;
Console.Write(firstN + ",");
Console.Write(secondN + ",");

for(int i=3; i<=num; i++)
{
    int newN = firstN+secondN;
    Console.Write("," + newN);
    firstN = secondN;
    secondN = newN;
}
