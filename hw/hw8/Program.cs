/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*
Console.WriteLine("Enter count rows of new array:");
int arr_rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter count cols of new array:");
int arr_cols = Convert.ToInt32(Console.ReadLine());
int[,] user_array = Create2DArray(arr_rows, arr_cols);
Print2DArray(user_array);
Console.WriteLine("Array with sort rows: ");
SortArray(user_array);
Print2DArray(user_array);

int [,] SortArray (int [,] arr)
{
    int temp;
    for (int i = 0;i<arr.GetLength(0);i++)
    {
        for (int j = 0;j < arr.GetLength(1)-1; j++)
        {
            for (int k = j+1;k < arr.GetLength(1);k++)
            {
                if (arr[i,j] > arr[i,k])
                    {
                        temp = arr[i,j];
                        arr[i,j] = arr[i,k];
                        arr[i,k] = temp;
                    }
            }
        }
    }
    return arr;
}
int[,] Create2DArray(int arr_rows, int arr_cols)
{
    int[,] arr = new int[arr_rows, arr_cols];
    for (int i = 0;i < arr_rows; i++)
    for (int j = 0;j < arr_cols; j++)
        arr[i,j] = new Random().Next(10);
    return arr;
}
void Print2DArray (int[,] arr)
{
    for (int i = 0;i < arr.GetLength(0) ; i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        Console.Write("{0}\t",arr[i,j]);
    Console.WriteLine();
    }
}
*/
/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
суммой элементов: 1 строка
*/
/*
Console.WriteLine("Enter count rows of new array:");
int arr_rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter count cols of new array:");
int arr_cols = Convert.ToInt32(Console.ReadLine());
while (!Check(arr_rows, arr_cols))
{
    Console.WriteLine("The number of rows and columns must not be equal!");
    Console.WriteLine("Please, enter values again!");
    Console.WriteLine("Enter count rows of new array:");
    arr_rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count cols of new array:");
    arr_cols = Convert.ToInt32(Console.ReadLine());
}

int[,] user_array = Create2DArray(arr_rows, arr_cols);
Console.WriteLine();
Print2DArray(user_array);
Console.WriteLine("Minimum sum of elements in {0} line",MinElemInArray(SumInRow(user_array)));

int [] SumInRow (int [,] arr)
{
    int [] sum = new int[arr.GetLength(0)];
    for (int i = 0;i < arr.GetLength(0);i++)
        for (int j = 0;j < arr.GetLength(1);j++)
            sum[i]+=arr[i,j];
    return sum;
}
int MinElemInArray (int [] arr)
{
    int min=Int32.MaxValue;
    int result=-1;
    for (int i = 0;i < arr.Length;i++)
    if (min>arr[i])
        {
        min=arr[i];
        result=i;
        }
    return(result);
}
bool Check (int rows, int cols)
{
    if (rows == cols)
        return false;
    return true;
}

int[,] Create2DArray(int arr_rows, int arr_cols)
{
    int[,] arr = new int[arr_rows, arr_cols];
    for (int i = 0;i < arr_rows; i++)
    for (int j = 0;j < arr_cols; j++)
        arr[i,j] = new Random().Next(10);
    return arr;
}
void Print2DArray (int[,] arr)
{
    for (int i = 0;i < arr.GetLength(0) ; i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        Console.Write("{0}\t",arr[i,j]);
    Console.WriteLine();
    }
}
*/
/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.WriteLine("Enter count rows of matrix A:");
int rows_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter count cols of matrix A:");
int cols_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter count rows of matrix B:");
int rows_B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter count cols of matrix B:");
int cols_B = Convert.ToInt32(Console.ReadLine());
while (!Check(arr_rows, arr_cols))
{
    Console.WriteLine("The number of columns of the first matrix must equal the number of rows of the second matrix!");
    Console.WriteLine("Please, enter values again!");
    Console.WriteLine("Enter count rows of matrix A:");
    int rows_A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count cols of matrix A:");
    int cols_A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count rows of matrix B:");
    int rows_B = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count cols of matrix B:");
    int cols_B = Convert.ToInt32(Console.ReadLine());

}

int [,] matrixA = Create2DArray(rows_A,cols_A);
int [,] matrixB = Create2DArray(rows_B,cols_B);

bool Check (int cols_A, int rows_B)
{
    if (rows_B !== cols_A)
        return false;
    return true;
}
int[,] Create2DArray(int arr_rows, int arr_cols)
{
    int[,] arr = new int[arr_rows, arr_cols];
    for (int i = 0;i < arr_rows; i++)
    for (int j = 0;j < arr_cols; j++)
        arr[i,j] = new Random().Next(10);
    return arr;
}
void Print2DArray (int[,] arr)
{
    for (int i = 0;i < arr.GetLength(0) ; i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        Console.Write("{0}\t",arr[i,j]);
    Console.WriteLine();
    }
}
/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы 
каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/