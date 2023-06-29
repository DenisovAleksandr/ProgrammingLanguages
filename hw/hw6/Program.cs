/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
/*
Console.WriteLine("Enter numbers separated by ',' ");
int[] numbers = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
Console.WriteLine("Number of positive numbers - "+PositiveNumbersCount(numbers));

int PositiveNumbersCount (int[] arr)
{
    int count = 0;
    for (int i = 0;i < arr.Length ; i++)
    {
        if (arr[i] > 0)
            count++;
    }
    return count;  
}
*/
/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
double[] coef = new double[4];
Console.WriteLine("Enter coefficient k1  for the first equation ");
coef[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coefficient b1 for the first equation ");
coef[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coefficient k2  for the second equation ");
coef[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coefficient b2 for the second equation ");
coef[3] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"First equation: y={coef[0]}x+{coef[1]}");
Console.WriteLine($"Second equation: y={coef[2]}x+{coef[3]}");
Console.Write("The point of intersection of two lines has coordinates: ");
PrintArray(FindPointOfIntersectionCoord(coef));

double [] FindPointOfIntersectionCoord (double[] coef)
{
    double[] coord_point = new double[2];
    coord_point[0] = (coef[3]-coef[1])/(coef[0]-coef[2]);
    coord_point[1] = coef[0]*coord_point[0] + coef[1];
    return coord_point;
}

void PrintArray (double[] arr)
{
    Console.Write("(");
    for (int i = 0;i < arr.Length ; i++)
        Console.Write(arr[i]+", ");
    Console.WriteLine("\b\b)");
}
