/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.*/

/*
int num = 0;
do{
    Console.WriteLine("Enter three digit number");
    num = Convert.ToInt32(Console.ReadLine()); 
}
while (!Check(num));

Console.WriteLine("The secondDigit is "+SecondDigit(num));

int SecondDigit (int num){
    return ((num/10)%10);
}

bool Check (int num) {
    if ((num/100>0)&& (num/100<9))
        return true;
    else return false;
}
*/
/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет.*/
/*
Console.WriteLine("Enter number");
int num = Convert.ToInt32(Console.ReadLine()); 

bool Check(int num){
        if ((num/100>0))
        return true;
    else
        return false;
}

int ThirdDigit(int num) {
    while (num/1000>0){
        num = num/10;
    }
    return (num%10);
}
if (!Check(num))
    Console.WriteLine("The third digit is missing");
else
    Console.WriteLine("The third digit is "+ThirdDigit(num));
*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день
недели, и проверяет, является ли этот день выходным.*/

Console.WriteLine("Enter number");
int num = Convert.ToInt32(Console.ReadLine()); 
while (!Check(num))
{
    Console.WriteLine("Invalid mumber! Please, enter number [1;7]");
    num = Convert.ToInt32(Console.ReadLine()); 
}
if (CheckWeekend(num))
    Console.WriteLine($"{num} day of the weeks is Weekend ");
    else
    Console.WriteLine($"{num} day of the weeks is not Weekend ");

bool Check(int num){
    if ((num>0)&&(num<8))
        return true;
    else 
        return false;
}

bool CheckWeekend (int num){
    if (num<6)
        return false;
    else
        return true;
}