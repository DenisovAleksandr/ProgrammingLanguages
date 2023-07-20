/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*Console.WriteLine("Enter N");
int n = Convert.ToInt32(Console.ReadLine());
WrireNaturalNumbers(1,n);

void WrireNaturalNumbers (int m,int n)
{
    if (n != m)
        WrireNaturalNumbers(m+1, n);
    Console.Write($"{m} ");
}
*/
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.WriteLine("Enter M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNaturalNumbers(m,n));

int SumNaturalNumbers (int m,int n)
{
    int result=0;
    if (n != m)
    return SumNaturalNumbers(Math.Min(m,n), Math.Max(m,n)-1)+Math.Max(m,n);
    else
    return m;
}

/*
Задача 68*: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/