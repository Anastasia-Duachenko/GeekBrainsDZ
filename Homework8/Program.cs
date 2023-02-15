/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
/*
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
SortToLower(array);
Console.WriteLine();
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }    
}

void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
*/
/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7*/
/*
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine($"Наименьшая строка массива - {SmallestNumber(array) + 1}.");

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }    
}

int SmallestNumber(int[,] array)
{
    int linenumber = 0;
    int minimum = 0;
    for (int rows = 0; rows < array.GetLength(1); rows ++)
    {
        minimum += array[0,rows];
    }

    for (int rows = 1; rows<array.GetLength(0); rows++)
    {
        int sum = 0;
        for (int columns = 0; columns < array.GetLength(1); columns ++)
        {
            sum+=array[rows,columns];
        }    
        if (minimum > sum)
        {
            minimum = sum;
            linenumber = rows;
        }
    } 
    return linenumber;
}
*/

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
/*
Console.Clear();

Console.Write("Введите количество строк 1 массива: ");
int rows1 = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов 1 массива: ");
int columns1 = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк 2 массива: ");
int rows2 = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов 2 массива: ");
int columns2 = int.Parse(Console.ReadLine());

 if (columns1 != rows2)
 {
    Console.WriteLine($"Введите новые равномерные матрицы..");
    return;
 }

int[,] First = GetArray(rows1, columns1, 0, 10);
int[,] Second = GetArray(rows2, columns2, 0, 10);
PrintArray(First);
Console.WriteLine();
PrintArray(Second);
Console.WriteLine();
PrintArray(CompositionArrays(First, Second));

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }    
}

int[,] CompositionArrays(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int row = 0; row < array1.GetLength(0); row ++)
    {
        for (int column = 0; column < array2.GetLength(1); column ++)
        {
            for (int c = 0; c < array1.GetLength(1); c ++)
            {
                array3[row, column] += array1[row, c] * array2[c, column];
            }
        }
    }
    return array3;
}*/

/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/
/*
string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,,] array = GetArray(new int[] { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]) }, 0, 100);
PrintArray(array);


int[,,] GetArray(int[] sizes, int min, int max)
{
    int[,,] result = new int[sizes[0], sizes[1], sizes[2]];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int k = 0;
            while(k < result.GetLength(2))
            {
                int element = new Random().Next(min, max + 1);
                if(FindElement(result, element)) continue;
                result[i, j, k] = element;
                k++;
            }
        }
    }
    return result;
}

bool FindElement(int[,,] array, int el)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if(array[i, j, k] == el) return true;
            }
        }
    }
    return false;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        } 
        Console.WriteLine();  
    }
}    */

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/
/*
Console.Write($"Введите число: ");
int a = int.Parse(Console.ReadLine());
int[,] array = SpiralArray(a);
PrintArray(array);

int[,] SpiralArray(int dimension)
{
    int[,] upshot = new int[dimension, dimension];
    int a = 0; 
    int b = 0; 
    int rowC = dimension - 1;
    int columnC = dimension - 1;
    int columnD = 0;
    int rowD = 0;
    bool left = true;
    bool top = true;
    int count = 0;
    while (count < dimension * dimension)
    {
        count++;
        upshot[a,b] = count;
        if (left && top)
        {
            if (b == columnC)
            {
                rowD++;
                top = true;
                left = false;
                a++;
                continue;
            }
            else
            {
                b++;
                continue;
            }
        }
        if (!left && top)
        {
            if (a == rowC)
            {
                columnC--;
                top = false;
                left = false;
                b--;
                continue;
            }
            else
            {
                a++;
                continue;
            }
        }
        if (!left && !top)
        {
            if (b == columnD)
            {
                rowC--;
                top = false;
                left = true;
                a--;
                continue;
            }
            else
            {
                b--;
                continue;
            }
        } 
        if (left && !top)
        {
            if (a == rowD)
            {
                columnD++;
                top = true;
                left = true;
                b++;
                continue;
            }
            else
            {
                a--;
                continue;
            }
        }       
    }  
    return upshot;
}    

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }    
}*/