/*Задача 3: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива.*/
void Print (double[] arr)
{
    int size=arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double [] mass(int length, double bottom, double top)
{
    double[] arr = new double[length];
    int c = 0;
    double r=Math.Abs(top-bottom);
    for (int i = 0; i < length; i++ )
    {
        if(bottom>0)
            {
                 arr[i]= new Random().NextDouble()*r+bottom;
            }
             
        else
           {
            c = new Random().Next(0,2);
            if (c==0)
                arr[i] = new Random().NextDouble()*top;
            else
                arr[i] = new Random().NextDouble()*bottom;
           }

    }
    return arr;
}

double Diff(double[] arr)
{
    double max=arr[0];
    double min=arr[0];
   for (int i = 0 ; i < arr.Length; i++)
   {
    if(arr[i]>max)
        max=arr[i];
    if(arr[i]<min)
        min=arr[i];
   }
   return max-min;
}

Console.WriteLine("enter the number of array elements");
int lenght1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the initial range");
double bottom1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the end range");
double top1 = int.Parse(Console.ReadLine()!);


double [] mas = mass(lenght1,bottom1,top1);
Console.WriteLine("array");
Print(mas);
double result = Diff(mas);
Console.WriteLine($"answer: {result}");

