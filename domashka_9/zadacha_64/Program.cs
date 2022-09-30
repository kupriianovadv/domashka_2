// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

string NaturalNum (int M, int N)
{
    if (M<=N) return $"{M} "+ NaturalNum(M+1,N);
    else return string.Empty;
}
Console.WriteLine(NaturalNum (m,n));

string NaturalNumBack (int M, int N)
{
    if (M>=N) return $"{M} "+ NaturalNumBack(M-1,N);
    else return string.Empty;
}
Console.WriteLine(NaturalNumBack (m,n));
