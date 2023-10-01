// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum(int m, int n)
{
if (m==n)
return n;
else return m + sum(m + 1, n);
}
Console.Write($"Сумма натуральных элементов в промежутке от M до N равно: {sum(m,n)}");

// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int akk(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return akk(m - 1, 1);
else return akk(m - 1, akk(m, n - 1));
}

Console.Write($"Функция Аккермана равно: {akk(m, n)} ");

// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
NatNum(num, count);


void NatNum(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NatNum(n, count + 1);
        Console.Write(count + " ");
    }
}