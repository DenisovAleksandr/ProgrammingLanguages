/*Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.*/
/*
Console.WriteLine("Enter five digit number");
int num = Convert.ToInt32(Console.ReadLine()); 


CheckPalindrome(num);
if (CheckPalindrome(num))
    Console.WriteLine(num+" is Palindrome");
else
    Console.WriteLine(num+" is not Palindrome");

int  NumberOfDigits (int num){
    int i = 1;
    while (num/10>0){
        num/=10;
        ++i;
    }
    return i;
}
bool CheckPalindrome (int num){
    for (int i = 0; i <= NumberOfDigits(num)/2; i++) {
        int leftDigit=Convert.ToInt32(num/(Math.Pow(10,NumberOfDigits(num)-1)));
        int rigthDigit=num%10;
        num=num/Convert.ToInt32(num%(Math.Pow(10,NumberOfDigits(num)-1)));
        num/=10;
        if (leftDigit!=rigthDigit)
        {
            return false;        }
    }
    return true;
}
*/
/*Задача 21 Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.*/
Console.WriteLine("Enter the coordinates of point A separated by commas. For example: 2,3,4");
int[] a= Console.ReadLine().Split(',').Select(int.Parse).ToArray();

Console.WriteLine("Enter the coordinates of point B separated by commas. For example: 2,3,4");
int[] b= Console.ReadLine().Split(',').Select(int.Parse).ToArray();
Console.WriteLine($"{DistanceAB(a,b)}");

double DistanceAB (int[] a, int[] b){
    return Math.Round(Math.Sqrt(Math.Pow(b[0]-a[0], 2) + Math.Pow(b[1]-a[1],2) + Math.Pow(b[2]-a[2], 2)),2);
}


/*Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт 
таблицу кубов чисел от 1 до N.*/

