/*Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.*/
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
int[,] MassNums(int row, int column, int to )
{
    int[,] arr = new int[row,column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i,j] = new Random().Next(to+1);
        }
    }   
    return arr;
}
int[] Frequency(int[,] arr, int to)
{
    int[] dict = new int [to+1];
    foreach (int element in arr)
    {
        dict[element]+=1;
    }
    return dict;
}
string PrintFrequency(int [] arr)
{
    string res = String.Empty;
    for (int i=0; i<arr.Length;i++)
    {
        res += $"Число {i} встречается {arr[i]} раз/n";
    }
    return res;
}
Console.WriteLine("enter the number of rows");
int row_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the number of columns");
int column_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("upper limit");
int stop = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int [,] mass = MassNums(row_num,column_num,stop);
Print(mass);

int[] dict = Frequency(mass,stop);
string res = PrintFrequency(dict);
Console.WriteLine(res);
