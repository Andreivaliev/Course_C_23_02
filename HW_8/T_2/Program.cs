/*Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/
void Print (int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    for (int i=0; i<row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    } 
}
int[,] MassNums(int row, int column, int from, int to )
{
    int[,] arr = new int[row,column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i,j] = new Random().Next(from,to+1);
        }
    }   
    return arr;
}
int SumRow(int[,] arr, int k)
{
    int sum = 0;
    int column = arr.GetLength(1);
    for (int i=0; i<column; i++)
    {
        sum=sum+arr[k,i];
    }
    return sum;
}

string MinSumRow(int[,] arr)
{
    string result =String.Empty;
    int f =0;
    int min = SumRow(arr,0);
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    for(int i=0; i < row; i++)
    {
       if(SumRow(arr,i)<min)
       {
        min=SumRow(arr,i);
        f=i;
       }
    }
    return $"Row {f+1}, Sum = {min}";
}

Console.WriteLine("enter the number of rows");
int row_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the number of columns");
int column_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("lower limit");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("upper limit");
int stop = int.Parse(Console.ReadLine()!);

Console.WriteLine();

int [,] mass = MassNums(row_num,column_num,start,stop);
Print(mass);

Console.WriteLine();

string result = MinSumRow(mass);
Console.WriteLine(result);
