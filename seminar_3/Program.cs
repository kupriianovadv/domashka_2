// Напишите программу, которая принимает на вход координаты X и Y не равные 0, и выдает номер четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Введите координату X: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();
// if (x>0 && y>0)
// {
//     Console.WriteLine("1");
// }
// if (x>0 && y<0)
// {
//     Console.WriteLine("2");
// }
// if (x<0 && y<0)
// {
//     Console.WriteLine("3");
// }
// if (x<0 && y>0)
// {
//     Console.WriteLine("4");
// }
// if (x==0 || y==0)
// {
//     Console.WriteLine("Определить нельзя");
// }

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (X и Y).

// Console.WriteLine("Введите номер четверти от 1 до 4: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num == 1)
// {
//     Console.WriteLine("X>0 Y>0");
// }
// if (num == 2)
// {
//     Console.WriteLine("x>0 y<0");
// }
// if (num == 3)
// {
//     Console.WriteLine("x<0 y<0");
// }
// if (num == 4)
// {
//     Console.WriteLine("x<0 y>0");
// }

// Напишите программу, которая принимает на вход координаты A и B и находит расстрояние между ними.

// Console.WriteLine("Введите координату X1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату X2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();

// double d = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
// Console.WriteLine(d);

// Напишите программу, которая принимает на вход число N, и выдает таблицу квадратов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count=1;

// for (int count = 1; count <= n; count++);
// {
//     double result = Math.Pow(count, 2);
//     Console.WriteLine(result);
// }

while (count <= n){
    double result = Math.Pow(count, 2);
    Console.WriteLine(result);
    count++;

}