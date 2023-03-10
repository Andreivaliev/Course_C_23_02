/* Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива*/
void Print (int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i<size; i++)
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

void SumPosNeg(int[] ar)
{
    int pos,neg;
    pos=neg=0;
    int size = ar.Length;
    for (int i = 0; i < size; i++)
    {
        if (ar[i]>0)
            pos+=ar[i];
        else
            neg+=ar[i];
    }
    Console.WriteLine($"Positive: {pos}; negative: {neg}");
}
Console.WriteLine("enter the number of array elements");
int mas1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the initial range");
int n1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the end range");
int k1 = int.Parse(Console.ReadLine()!);

int[] mas = massiv(mas1,n1,k1);
Print(mas);
SumPosNeg(mas);