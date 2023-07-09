double[,] GenerateArray(int arr_rows, int arr_cols)
{
    Random rand = new Random();
    double[,] arr = new double[arr_rows, arr_cols];
    for (int i = 0;i < arr_rows; i++)
        for (int j = 0;j<arr_cols;j++)
        arr[i,j] =Math.Round((MIN + rand.NextDouble()*(MAX-MIN)),2);
    return arr;
}
void PrintArray (double[,] arr)
{
    Console.Write("[");
    for (int i = 0;i < arr.length(1) ; i++)
        for(int j = 0; j < arr.length(0); j++)
        Console.Write(arr[i]+", ");
    Console.WriteLine("\b\b]");
}