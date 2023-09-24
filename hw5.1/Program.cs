// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

void GetArray(int a)
{
for (int i = 0; i < a; i++)
{
randomArray[i] = new Random().Next(99,999);
Console.Write(randomArray[i] + " ");
}

}

int RanNum(int[] randomArray)
{
int RanNum = 0;
for (int i = 0; i < randomArray.Length; i++)
{
if (randomArray[i] % 2 == 0)
RanNum = RanNum + 1;
}
return RanNum;
}

GetArray(a);
Console.Write($"Количество чётных чисел в массиве: {RanNum(randomArray)}");


Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

 void GetArray(int a)
{
for (int i = 0; i < a; i++)
{
randomArray[i] = new Random().Next(1,999);
Console.Write(randomArray[i] + " ");
}

}

 int RanNum(int[] randomArray)
{
int sum = 0;
int i = 1;

while (i < randomArray.Length)
{
    sum = sum + randomArray[i];
    i = i + 2;
}
return sum;
}

GetArray(a);
Console.Write($"Сумма элементов, стоящих на нечётных позициях: {RanNum(randomArray)}");

Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];

 void GetArray(int a)
{
Random num = new Random();
for (int i = 0; i < a; i++)
{
randomArray[i] = num.NextDouble();
Console.Write($"{randomArray[i]} ");
// Console.Write($"{randomArray[i]:F2} ");
}
}

double rez(double[] randomArray)
{
double min = randomArray[0];
double max = randomArray[0];
int i = 1;

while (i < randomArray.Length)
{
if (max<randomArray[i])
max = randomArray[i];
if (min>randomArray[i])
min = randomArray[i];
i = i + 1;
}
return max-min;
}

GetArray(a);
Console.Write($"Разница между максимальным и минимальным элементов массива: {rez(randomArray)}");