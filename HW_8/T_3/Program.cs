/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/
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
int[,] MassNums1(int row, int column, int from, int to )
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

int[,] MassNums2(int row, int column, int from, int to )
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


void СompositMatr(int[,] mass, int[,] arr)
{
    int row1 = mass.GetLength(0);
    int column1 = mass.GetLength(1);
    int row2 = arr.GetLength(0);
    int column2 = arr.GetLength(1);
    if (row2 !=column1)
{
    Console.WriteLine("the product of matrices does not exist");
    return;
}
else
{
    int c =0 ;
    int [,] new_massiv = new int[row1,column2];
for (int i=0; i < row1; i++)
{  
      for (int k=0; k <column2; k++)
    {
        for(int j =0 ; j<row2; j++)
        {
            c=c+mass[i,j]*arr[j,k];
        }
    new_massiv[i,k]=c;
    Console.Write($"{new_massiv[i,k]} ");
    c=0;
    }
    Console.WriteLine();
}
}
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

int [,] mass_1 = MassNums1(row_num,column_num,start,stop);
Print(mass_1);

Console.WriteLine("enter the number of rows");
int row_num_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the number of columns");
int column_num_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("lower limit");
int start_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("upper limit");
int stop_2 = int.Parse(Console.ReadLine()!);

Console.WriteLine();

int [,] mass_2 = MassNums2(row_num_2,column_num_2,start_2,stop_2);
Print(mass_2);




Console.WriteLine();

СompositMatr(mass_1,mass_2);

