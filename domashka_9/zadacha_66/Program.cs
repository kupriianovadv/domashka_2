// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());


string SumNumber (int M, int N)
{
    if (M<=N) return (M + SumNumber(M+1,M)); 
    else return string.Empty;
}
Console.WriteLine(SumNumber(m,n));