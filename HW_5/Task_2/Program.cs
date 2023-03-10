/*Задача 2: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.*/
void Print (int[] arr)
{
    int size=arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] mass(int length, int bottom, int top)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++ )
    {
        arr[i]=new Random().Next(bottom,top+1);
    }
    return arr;
}

int SumОdd(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i+=2)
    {
        count = count + arr[i];
    }
    return count;
}

Console.WriteLine("enter the number of array elements");
int lenght1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the initial range");
int bottom1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the end range");
int top1 = int.Parse(Console.ReadLine()!);

int[] mas = mass(lenght1,bottom1,top1);
Print(mas);
int result = SumОdd(mas);
Console.WriteLine(result);
