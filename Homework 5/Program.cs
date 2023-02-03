/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
/*
Console.Clear();
int[] MassivArray(int N, int start, int end)
{
    int[] NewArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        NewArray[i] = new Random().Next(start, end + 1);
    }
    return NewArray;
} 
int[] Massiv = MassivArray(4, 100, 999);
Console.WriteLine(String.Join(" ", Massiv));
Console.WriteLine(FoundCount(Massiv));

int FoundCount(int[] array)
{
    int count = 0;
    foreach (var i in array)
    {
        if (i % 2 == 0) count++;
    }
    return count;
}
*/
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
/*
Console.Clear();
int[] MassivArray(int N, int start, int end)
{
    int[] NewArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        NewArray[i] = new Random().Next(start, end + 1);
    }
    return NewArray;
} 
int[] Massiv = MassivArray(4, -100, 100);
Console.WriteLine(String.Join(" ", Massiv));
Console.WriteLine(FoundCount(Massiv));

int FoundCount(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+= 2)
    {
        sum += array[i];  
    }
    return sum;
} 
*/

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
/*
Console.Clear();
int[] MassivArray(int N, int start, int end)
{
    int[] NewArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        NewArray[i] = new Random().Next(start, end + 1);
    }
    return NewArray;
} 
int[] Massiv = MassivArray(4, 0, 10);
Console.WriteLine(String.Join(" ", Massiv));
Console.WriteLine(FoundCount(Massiv));

int FoundCount(int[] array)
{
    int min = array[0];
    int max = array[0];
    foreach (var i in array)
    {
        if (min > i) min = i;
        if (max < i) max = i;
    }
    return max - min;
}*/
 
 
