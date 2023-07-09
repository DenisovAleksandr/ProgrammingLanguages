/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
/*Console.WriteLine("Enter count rows of new array:");
int arr_rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter count cols of new array:");
int arr_cols = Convert.ToInt32(Console.ReadLine());

double [,] array2d = GenerateArray(arr_rows, arr_cols);
PrintArray(array2d);

double[,] GenerateArray(int arr_rows, int arr_cols)
{
    Random rand = new Random();
    double[,] arr = new double[arr_rows, arr_cols];
    for (int i = 0;i < arr_rows; i++)
        for (int j = 0;j<arr_cols;j++)
        arr[i,j] =Math.Round(rand.NextDouble(),2)+rand.Next(10);
    return arr;
}
void PrintArray (double[,] arr)
{
    for (int i = 0;i < arr.GetLength(0) ; i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        Console.Write("{0}\t",arr[i,j]);
    Console.WriteLine();
    }
}
*/
/*Задача 50. Напишите программу, которая на вход принимает позиции элемента
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
/*
int arr_cols = new Random().Next(9)+1;
int arr_rows = new Random().Next(9)+1;
Console.WriteLine("Enter the ROW number of the element you are looking for:");
int user_row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the COLUMN number of the element you are looking for:");
int user_col = Convert.ToInt32(Console.ReadLine());
int[,] arr = CreateArray(arr_rows, arr_cols);
PrintArray(arr);
if (user_row>arr_rows-1)
    Console.WriteLine("Sorry, This array has only {0} rows!",arr_rows);
    else if (user_col>arr_cols-1)
        Console.WriteLine("Sorry, This array has only {0} cols!",arr_cols);
        else Console.WriteLine("Your elemint on posotion ({0};{1}) is: {2} ", user_row,user_col,arr[user_row, user_col]);

int[,] CreateArray(int arr_rows, int arr_cols)
{
    int[,] arr = new int[arr_rows, arr_cols];
    for (int i = 0;i < arr_rows; i++)
    for (int j = 0;j < arr_cols; j++)
        arr[i,j] = new Random().Next(10);
    return arr;
}

void PrintArray (int[,] arr)
{
    for (int i = 0;i < arr.GetLength(0) ; i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        Console.Write("{0,3}",arr[i,j]);
    Console.WriteLine();
    }
}
*/

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine("Enter count rows of new array:");
int arr_rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter count cols of new array:");
int arr_cols = Convert.ToInt32(Console.ReadLine());
int[,] arr=CreateArray(arr_rows, arr_cols);
PrintArray(arr);
double [] avarage = AverageCols(arr);
Console.WriteLine("Avarage:");
for (int i = 0; i < avarage.Length; i++)
Console.Write("{0,2}\t", avarage[i]);

int[,] CreateArray(int arr_rows, int arr_cols)
{
    int[,] arr = new int[arr_rows, arr_cols];
    for (int i = 0;i < arr_rows; i++)
    for (int j = 0;j < arr_cols; j++)
        arr[i,j] = new Random().Next(10);
    return arr;
}

void PrintArray (int[,] arr)
{
    for (int i = 0;i < arr.GetLength(0) ; i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        Console.Write("{0}\t",arr[i,j]);
    Console.WriteLine();
    }
}
double [] AverageCols (int [,] arr)
{
    double [] avarage = new double[arr.GetLength(1)];

    for (int j =0;j < arr.GetLength(1);j++)
    {
        int sum = 0;
        for (int i=0;i<arr.GetLength(0);i++)
            sum+=arr[i,j];
        avarage[j]=sum*1.0/arr.GetLength(0);
    }
    return avarage;

}