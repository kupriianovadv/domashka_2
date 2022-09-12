// Задача 39. Напишите программу, которая перевернет одномерный массив.
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int [] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(", ", array));

ReversArray(array);
Console.WriteLine(String.Join(", ", array));

int [] GetArray (int size, int MinValue, int MaxValue)
{
    int [] res = new int [size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(MinValue, MaxValue);
    }
    return res;
}

void ReversArray (int [] InArray)
{
    for(int i=0; i<InArray.Length/2; i++)
    {
        int k = InArray[i];
        InArray[i] = InArray[InArray.Length-1-i];
        InArray[InArray.Length-1-i] = k;
    }
}
