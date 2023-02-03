/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
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
int[] Massiv = MassivArray(5, -100, 100);
Console.WriteLine(String.Join(" ", Massiv));
Console.WriteLine(FoundCount(Massiv));

int FoundCount(int[] array)
{
    int count = 0;
    foreach (var i in array)
    {
        if (i > 0) count++;
    }
    return count;
}
*/

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
/*Console.Clear();
Console.Write("Введите значения чисел через запятую b1, k1, b2, k2:");
string[] t = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
double b1 = double.Parse(t[0]);
double k1 = double.Parse(t[1]);
double b2 = double.Parse(t[2]);
double k2 = double.Parse(t[3]);

Console.WriteLine(String.Join(" ", ArrayNumbers(b1, k1, b2, k2)));

double[] ArrayNumbers(double A1, double B1, double A2, double B2)
{
    double[] upshot = new double[2];
    upshot[0] = (A2 - A1) / (B1 - B2);
    upshot[1] = B1 * upshot[0] + A1;
    return upshot;
}*/
