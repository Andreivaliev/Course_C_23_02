/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/

double RangeDouble(int from, int to)
{
    double result = 0;
    int min = from;
    int max = to;

    if (max < from)
        {
            max = from;
            min = to;
        }

    if(max < 0 && min < 0)
        {
            result = - new Random().NextDouble()*(max - min)+max;
        }

    if(max > 0 && min >0 )
        {
            result = new Random().NextDouble()*(max-min)+min;
        }
    
    if(min < 0 && max >= 0)
        {
            int r = new Random().Next(0,2);
            if( r == 0)
            {
                result = new Random().NextDouble()*(min);
            }
            else
            {
                result = new Random().NextDouble()*(max);
            }
        }
    return result;    
}
void Print (double [,] arr)
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

double[,] MassNums(int row, int column, int from, int to, int sign )
{
    double [,] arr = new double [row,column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i,j] = Math.Round(RangeDouble(from,to),sign);
        }
    }   
    return arr;
} 
 
Console.WriteLine("enter the number of rows");
int row_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the number of columns");
int column_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("upper limit");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("lower limit");
int stop = int.Parse(Console.ReadLine()!);
Console.WriteLine("rounding sign");
int sign_n = int.Parse(Console.ReadLine()!);
Console.WriteLine();

double [,] mass = MassNums(row_num,column_num,start,stop,sign_n);
Print(mass);