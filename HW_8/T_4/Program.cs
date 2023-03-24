/*Задайтедвумерный массив из целых чисел. Напишите программу,
которая удалит строку и столбец, на пересечении которых расположен
наименьший элемент массива.*/
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
int MinMatr (int[,] arr, int c)
{
    int l=0;
    int k=0;
    int min = arr[0,0];
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

   for(int i =0; i<row; i++)
    {
        for(int j = 0 ; j < column; j++)
        {
          if(arr[i,j]<min)
          {
            min=arr[i,j];
            l=i;
            k=j;
          }
        }
    }

  if(c==1)
    {
        return l;
    }
  else
    {
        return k;
    }
}
   
void DelRowColumn(int[,] arr)
{

    int l=MinMatr(arr,1);
    int k=MinMatr(arr,2);
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    
    int[,] arr_new = new int[row,column];
    {
        for (int i=0; i<row;i++)
        {
                    for (int j = 0; j < column; j++)
                    {
                    arr_new[i,j]=arr[i,j];  
                    if(i==l||j==k)
                    {
                    Console.Write("");
                    }
                    else
                    {
                    Console.Write($"{arr_new[i,j] } ");
                    }
                    }  
            if (i!=l)
            {
            Console.WriteLine();
            }
        }
    
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
Console.WriteLine("enter the number of rows");
int row_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the number of columns");
int column_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("lower limit");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("upper limit");
int stop = int.Parse(Console.ReadLine()!);

Console.WriteLine();

int [,] mass_1 = MassNums(row_num,column_num,start,stop);
Print(mass_1);

Console.WriteLine();

DelRowColumn(mass_1);