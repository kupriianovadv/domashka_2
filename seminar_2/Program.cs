// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int num = new Random().Next(10,100);
// int num1 = num/10;
// int num2 = num%10;
// int max = num1;

// Console.WriteLine(num);

// if (max<num2)
// {
//     max = num2;
// }

// Console.WriteLine(max);

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// int num = new Random().Next(100,1000);

// int num1 = num/100;
// int num_2 = num%100; int num2 = num_2/10;
// int num3 = num%10;

// Console.WriteLine(num);
// Console.Write(num1);
// Console.Write(num3);

// Напишите программу, которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23.

// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num%7 == 0 && num%23 == 0)
// {
//     Console.WriteLine("Условие выполнено!");
// }
// else
// {
//     Console.WriteLine("Условие не выполнено!");
// }

// Напишите программу, которая принимает на вход два числа и проверяет является ли одно число квадратом другого.

Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2*num2 || num2 == num1*num1)
{
    Console.WriteLine("Условие выполнено!");
}
else
{
    Console.WriteLine("Условие не выполнено!");
}