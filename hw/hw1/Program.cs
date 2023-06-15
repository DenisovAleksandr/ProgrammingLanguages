/*Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.*/

/*
Console.WriteLine("Input first numbers: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second numbers: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1<number2) Console.WriteLine("max - "+number2+"; min - "+number1);
    else if (number2<number1) Console.WriteLine("max - "+number1+"; min - "+number2);
        else Console.WriteLine("the numbers are equal");
*/

/*Задача 4: Напишите программу, которая принимает на вход три числа и 
выдаёт максимальное из этих чисел.*/
/*
Console.WriteLine("Input first numbers: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second numbers: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third numbers: ");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 < number2){
    if (number2 < number3)    
        Console.WriteLine("max - "+number3);
    else
        Console.WriteLine("max - "+number2);
    
} else 
{
    if (number1 < number3)    
        Console.WriteLine("max - "+number3);
    else
        Console.WriteLine("max - "+number1);
}
*/
/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).*/
Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 != 0)
Console.WriteLine(number + " - odd number");
else
Console.WriteLine(number + " - even number");

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.*/
