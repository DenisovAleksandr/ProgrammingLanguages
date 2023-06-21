/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
/*
Console.WriteLine("Enter number:");
int user_num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter pow B:");
int user_pow = Convert.ToInt32(Console.ReadLine());
while (!Check(user_pow))
{
    Console.WriteLine("Enter NATURAL pow B:");
    user_pow = Convert.ToInt32(Console.ReadLine()); 
}

Console.WriteLine("A^b= "+APowB(user_num,user_pow));

bool Check (int user_pow){
    if ((user_pow%1==0)&&(user_pow>0))
    return true;
    return false;
}

int APowB (int user_num, int user_pow)
{
    int result = 1;
    for (int i = 0;i<user_pow;i++)
    result*=user_num;
    return result;
}

*/
/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму 
цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
/*
Console.WriteLine("Enter number:");
int user_num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The sum of the digits in a number - "+ SumDigit(user_num));


int SumDigit (int user_num)
{
    int result = 0;
    user_num = Math.Abs(user_num);
    while (user_num > 0)
    {
        result+=user_num%10;
        user_num/=10;
    }
    return result;
}
*/

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит 
их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
Console.WriteLine("Enter array's length:");
int lengthArr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the minimum value of the array element:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the maximum value of the array element:");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(lengthArr,min,max);
PrintArray(arr);
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