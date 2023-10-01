// Задайте двумерный массив. Напишите программу, которая упорядочит
//  по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите размерность a массива: "); //высота массива
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность b массива: "); //длина массива
int b = Convert.ToInt32(Console.ReadLine());
int[,] randomArr = new int[a,b]; //  это прямоугольный массив - один объект, который имеет два измерения. Каждый элемент массива является целым числом; все элементы хранятся в памяти последовательно.


void mas(int a, int b) //заполнение массива
{
int i,j;
Random mass = new Random();
for (i = 0; i < a; i++)
{
for (j = 0; j < b; j++)
{
randomArr[i,j] = mass.Next(1,9);
}
}
}

void print(int[,] array)
{
int i,j;
for (i = 0; i < array.GetLength(0); i++)
{
Console.WriteLine();
for (j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i,j]} ");
}
Console.WriteLine();
}

}

mas(a,b);
Console.WriteLine("\nИсходный массив: ");
print(randomArr);

void total(int[,] array) //сортировка массива. упорядочность
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
total(randomArr);
Console.WriteLine("\nОтсортированный массив: ");
print(randomArr); // вывод


// Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.

Console.Write("Введите размерность a массива: "); //высота массива
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность b массива: "); //длина массива
int b = Convert.ToInt32(Console.ReadLine());
int[,] randomArr = new int[a,b];


void mas(int a, int b) //заполнение массива
{
int i,j;
Random mass = new Random();
for (i = 0; i < a; i++)
{
for (j = 0; j < b; j++)
{
randomArr[i,j] = mass.Next(1,9);
}
}
}

void print(int[,] array)
{
int i,j;
for (i = 0; i < array.GetLength(0); i++)
{
Console.WriteLine();
for (j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i,j]} ");
}
Console.WriteLine();
}

}

mas(a,b);
Console.WriteLine("\nИсходный массив: ");
print(randomArr);

int Sum(int[,] array, int i) // сумма 
{
int sum = array[i,0];
for (int j = 1; j < array.GetLength(1); j++)
{
sum += array[i,j];
}
return sum;
}

int minSum = 1;
int sum = Sum(randomArr, 0);
for (int i = 1; i < randomArr.GetLength(0); i++)
{
if (sum > Sum(randomArr, i))
{
sum = Sum(randomArr, i);
minSum = i+1;
}
}
Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");


// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.Write("Введите размерность a массива: "); //поле
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность b массива: "); //строка
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность с массива: "); //столбец
int c = Convert.ToInt32(Console.ReadLine());
 int[,,] array = RandomArray(a, b, c);
         Array3d(array);

int[,,] RandomArray( int a, int b, int c)
 { 
    int[,,] newArray = new int[a, b, c]; //выделяем память под двумерный массив
  for(int i = 0; i < a; i++) // прохождение по строкам 
  { 
    for(int j = 0; j < b; j++) // прохождение по столбцам
   { 
    for(int k = 0; k < c; k++) 
   { 
    newArray[i,j,k] = i + j + k;
    }
     } 
     } 
     return newArray; 
     } 
     void Array3d(int[,,] array) // показываем двумерный массив
      { 
        for (int i = 0; i < array.GetLength(0); i++) 
      {
         for(int j = 0; j < array.GetLength(1); j++) 
      { 
        for(int k = 0; k < array.GetLength(2); k++) 
      { 
        Console.Write("[" + i + "," + j + "]" + array[i, j, k] + " "); 
      } 
      Console.WriteLine(); 
      } 
      Console.WriteLine(); 
      } 
      Console.WriteLine();
      }
  

//   Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int n = 4; //Размер массива
int[,] mass = new int[n, n];

int k = 1; // элемент заполнения
int i = 0;
int j = 0;

while (k <= mass.GetLength(0) * mass.GetLength(1))
{
  mass[i, j] = k;
  k++;
  if (i <= j + 1 && i + j < mass.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= mass.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > mass.GetLength(1) - 1)
    j--;
  else
    i--;
}

ArraySp(mass);

void ArraySp (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}