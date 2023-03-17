/*Задайте двумерный массив. Введите элемент, и найдите
первое его вхождение, выведите позиции по горизонтали и
вертикали, или напишите, что такого элемента нет.*/
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
void  Search(int[,] mass, int a)
{
    
    int row = mass.GetLength(0);
    int column = mass.GetLength(1);
    
    for(int i=0; i<row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (a==mass[i,j])
            {
               Console.WriteLine($" {i} , {j} ") ;
               return;
            }
        }
    }
}
int row_num = int.Parse(Console.ReadLine()!);
int column_num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter a number");
int a = int.Parse(Console.ReadLine()!);

int[,] mass_1 = MassNums(row_num,column_num,start,stop);
Print(mass_1);
Console.WriteLine();

Search(mass_1,a);

