
Console.WriteLine($"Enter numbers separated by ',' ");
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

