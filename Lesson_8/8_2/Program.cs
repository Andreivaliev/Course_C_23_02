/*Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.*/
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
bool Check(int row,int column)
{
    bool result = row != column;
    return result;
}
string Trans(int[,] arr)
{
    if (Check(arr.GetLength(0),arr.GetLength(1))) return "No";
    for (int i = 1; i< arr.GetLength(0);i++)
    {
        for (int j = 0; j < i ; j++)
        {
            (arr[i,j],arr[j,i])=(arr[j,i],arr[i,j]);
        }
    }
    return "yes";
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
Check(row_num,column_num);
Print(mass);
Console.WriteLine();
string result = Trans(mass);
Console.WriteLine(result);
Print(mass);