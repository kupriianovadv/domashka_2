// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write("Сколько чисел Вы хотите ввести? ");
int M = Convert.ToInt32(Console.ReadLine());

int [] array = new int[M];
int sum = 0;

for(int i=0; i<=(M-1); i++)
{
    Console.Write("ВВедите число: ");
    array [i] = Convert.ToInt32(Console.ReadLine());
    if(array[i]>0)
    {
       sum++;
    }
}
Console.WriteLine(String.Join(", ",array));
Console.WriteLine("Количество чисел > 0: " + sum);