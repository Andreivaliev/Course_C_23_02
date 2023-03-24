/*Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.*/
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
void Replace(int[,] arr)
{
    int ArrayRow = arr.GetLength(0);
    int ArrayColumn = arr.GetLength(1);
    for (int j = 0; j < ArrayColumn; j++)
    {
        (arr[0,j],arr[ArrayRow-1,j]) = (arr[ArrayRow-1,j],arr[0,j]);
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
Replace(mass);
Print(mass);