// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
Console.WriteLine("Введите число B: ");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Число А в степени числа В = " + GetSquare());

int GetSquare(int num)
{
    int square = 0;
    int count = 0;

    while (square>count)
    {
        count++;
        square = A*B;
    }
    return square;
}