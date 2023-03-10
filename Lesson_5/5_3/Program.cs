/* Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99] */

void Print (int[] arr)
{
    for (int i = 0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");  
    }
    Console.WriteLine();
}
    
int[] massiv(int mas,int n, int k)
{
    int [] numbers= new int [mas];
    for (int i=0; i<mas; i++)
    {
        numbers[i] = new Random().Next(n,k+1);
    }
    return numbers;
}
int Count(int[] mas, int go, int stop)
{
    int c;
    c=0;
    for(int i =0; i< mas.Length; i++)
    {
        if(mas[i]>=go && mas[i]<=stop)
            c+=1;
    }
    return c;
}
Console.WriteLine("enter the number of array elements");
int mas1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the initial range");
int n1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the end range");
int k1 = int.Parse(Console.ReadLine()!);

int[] mas = massiv(mas1,n1,k1);
Print(mas);

Console.WriteLine("enter the initial range");
int go = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the end range");
int stop = int.Parse(Console.ReadLine()!);

int result = Count(mas,go,stop);
Console.WriteLine(result);