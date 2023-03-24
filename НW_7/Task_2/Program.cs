/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.*/
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
string Search(int[,] mass, int j, int k)
{
    if ((mass.GetLength(0)<j )|| (mass.GetLength(1)<k))
    {
        return "The number is missing";
    }
    else
    {
        return $"{mass[j-1,k-1]} ";
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

Console.WriteLine("row");
int j1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("column");
int k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine();
string result = Search(mass,j1,k1);
Console.WriteLine(result);

