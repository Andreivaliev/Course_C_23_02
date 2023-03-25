/*Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/
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
int[,] MassNums(int row, int column,int from, int to )
{
    int[,] arr = new int[row,column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i,j] = new Random().Next(from, to+1);
        }
    }   
    return arr;
}
string SortingRow(int[,] arr, int k)
{
    string result = String.Empty;
    int column = arr.GetLength(1);
    int[] mas = new int [column];
    
    for (int i=0; i<column; i++)
    {
        for (int j=0; j<column-i-1; j++)
        {
            if (arr[k,j]<arr[k,j+1])
            {
                (arr[k,j+1],arr[k,j])=(arr[k,j],arr[k,j+1]);
                
            }
        }
        mas[i]=arr[k,column-i-1];
        result =  $"{mas[i]} " + result;
    }
    return result;
}

void SortMass(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int[,] massiv = new int [row,column];
    for(int i=0; i < row; i++)
    {
        Console.WriteLine(SortingRow(arr,i));
    }
    Console.WriteLine();
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
SortMass(mass);