/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
/*
Console.WriteLine("Enter array's length ");
int lengthArr = Convert.ToInt32(Console.ReadLine());

int [] arr = GenerateArray(lengthArr);
PrintArray(arr);
Console.WriteLine("Count of even elements: "+CountEvenElem(arr));

int CountEvenElem (int [] arr) 
{
    int count = 0;
    for (int i = 0;i<lengthArr;i++)
    {
        if (CheckEven(arr[i]))
            count++;
    }
    return count;
}
bool CheckEven(int number)
{
    if(number%2==0)
        return true;
    else
        return false;
}
int[] GenerateArray(int lengthArr)
{
    Random rand = new Random();
    int[] arr = new int[lengthArr];
    for (int i = 0;i < lengthArr; i++)
        arr[i] = rand.Next(100,1000);
    return arr;
}
void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0;i < arr.Length ; i++)
        Console.Write(arr[i]+", ");
    Console.WriteLine("\b\b]");
}
*/
/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
Console.WriteLine("Enter array's length ");
int lengthArr = Convert.ToInt32(Console.ReadLine());
int [] arr = GenerateArray(lengthArr);
PrintArray(arr);
Console.WriteLine("The sum of elements in odd positions: "+SumElemOddPos(arr));
int SumElemOddPos (int[] arr) 
{
    int sum=0;
    for (int i = 1;i < arr.Length; i=i+2)
    {
        sum+=arr[i];
    }
    return sum;
}
int[] GenerateArray(int lengthArr)
{
    Random rand = new Random();
    int[] arr = new int[lengthArr];
    for (int i = 0;i < lengthArr; i++)
        arr[i] = rand.Next(1,10);
    return arr;
}
void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0;i < arr.Length ; i++)
        Console.Write(arr[i]+", ");
    Console.WriteLine("\b\b]");
}
*/
/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
 и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/
const double MIN = -10;
const double MAX = 10;
Console.WriteLine("Enter array's length ");
int lengthArr = Convert.ToInt32(Console.ReadLine());
double [] arr = GenerateArray(lengthArr);
PrintArray(arr);
Console.Write($"difference between maximum and minimum elements:{MaxElem(arr)}-{MinElem(arr)} = ");
Console.WriteLine(MaxElem(arr)-MinElem(arr));
double MaxElem (double[] arr)
{
    double maximum = MIN;
    for (int i = 0;i<lengthArr;i++)
        if (arr[i]>maximum)
            maximum = arr[i];
    return maximum;
}
double MinElem (double[] arr)
{
    double minimum = MAX;
    for (int i = 0;i<lengthArr;i++)
        if (arr[i]<minimum)
            minimum = arr[i];
    return minimum;
}
double[] GenerateArray(int lengthArr)
{
    Random rand = new Random();
    double[] arr = new double[lengthArr];
    for (int i = 0;i < lengthArr; i++)
        arr[i] =Math.Round((MIN + rand.NextDouble()*(MAX-MIN)),2);
    return arr;
}
void PrintArray (double[] arr)
{
    Console.Write("[");
    for (int i = 0;i < arr.Length ; i++)
        Console.Write(arr[i]+", ");
    Console.WriteLine("\b\b]");
}