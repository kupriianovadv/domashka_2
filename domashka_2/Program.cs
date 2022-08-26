// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.WriteLine("Введите трехзначное число:");
// int num = Convert.ToInt32(Console.ReadLine());

// int num_2 = num%100; int num2 = num_2/10;

// Console.WriteLine(num2);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.WriteLine("Введите число:");
// string num = Console.ReadLine();

// char[] array = num.ToArray();
// int n = array.Length;

// if (n < 3)
// {
//     Console.WriteLine("Третьей цифры в заданном числе нет");
// }
// if (array[2] >= 0)
// {
//   Console.WriteLine($"Третья по счету цифра заданного Вами числа -  {array[2]}");  
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7:");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 6 && num < 8)
{
    Console.WriteLine("Выходной день!");
}
if (num > 7 || num <= 0)
{
    Console.WriteLine("Ошибка");
}
else
{
    Console.WriteLine("Будний день");
}
