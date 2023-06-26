/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
Console.WriteLine("Enter array's length ");
int lengthArr = Convert.ToInt32(Console.ReadLine());

int [] arr = GenerateArray(lengthArr);
PrintArray(arr);

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


/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
 и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/


int[] CreateArray(int lengthArr, int min, int max)
{
    Random rand = new Random();
    int[] arr = new int[lengthArr];
    for (int i = 0;i < lengthArr; i++)
        arr[i] = rand.Next(min,max+1);
    return arr;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0;i < arr.Length ; i++)
        Console.Write(arr[i]+", ");
    Console.WriteLine("\b\b]");
}