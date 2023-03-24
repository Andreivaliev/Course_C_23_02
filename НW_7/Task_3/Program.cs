/*Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.*/
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
            arr[i,j] = new Random().Next(from,to);
        }
    }   
    return arr;
}

void Average(int[,] mass)
{
    double result;
    int rows = mass.GetLength(0);
    int columns = mass.GetLength(1);
    for (int j=0; j<columns; j++)
    {
        int k=0;
        result=0;
        for (int i = 0; i < rows; i++)
        {
            result=result+mass[i,j];
            k=i+1;
        }
        result=(double)result/k;
        Console.WriteLine ($"Arithmetic mean of the column {j+1} = {result}");
    }
}

Console.WriteLine("enter the number of rows");
int row_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the number of columns");
int column_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("upper limit");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("lower limit");
int stop = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int [,] mass = MassNums(row_num,column_num,start,stop);
Print(mass);

Console.WriteLine();
Average(mass);

