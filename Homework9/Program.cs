/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine());
PrintNumbers(N, 1);

void PrintNumbers(int end, int start)
{
    Console.Write($"{end} ");
    if (start == end) return;
    PrintNumbers(end - 1, start);
}*/

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.*/
/*
Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine());
NumberSum(M, N, 0);
void NumberSum (int start, int end, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + M++;
    NumberSum(M, N, sum);
}
*/

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
/*
Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());
Console.Write($"Функция Аккермана = {Ackerman(m, n)}.");

int Ackerman(int start, int end)
{
  if (start == 0) return end + 1;
  else if (end == 0) return Ackerman(start - 1, 1);
  else return Ackerman(start - 1, Ackerman(start, end - 1));
}
*/

