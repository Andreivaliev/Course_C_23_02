/*Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования*/
int [,] FillMass(int rows, int columns, int from , int to)
{
    int [,] Array= new int [rows,columns];
    for(int i=0; i< rows; i++)
    {
        for (int j = 0; j<columns; j++)
        {
            Array[i,j] = new Random().Next(from,to);
        }
    }
    return Array;
}

void PrinOff(int[,] arr)
{
    for (int i = 0; i<arr.GetLength(0); i++)
    {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
        Console.Write($" {arr[i,j]} ");
       } 
       Console.WriteLine();
    }   
}

int [,] MassCopy(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int[,] new_Arr = new int[rows,columns];
    for(int i = 0; i< rows; i++)
    {
        for(int j = 0; j<columns;j++)
        {
            new_Arr[i,j] = arr[i,j]; 
        }
    }
    return new_Arr;
}
int [,] mas = FillMass(4,5,1,11);
PrinOff(mas);
Console.WriteLine();
int[,] new_mas = MassCopy(mas);
PrinOff(new_mas);
