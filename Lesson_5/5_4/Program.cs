/*Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.*/
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
int[] sum_mas(int[] mas)
{
    
    int size = mas.Length;
    int [] new_mas = new int [size/2+size%2];     
    for (int  i=0; i< size/2+size%2;i++)
    {
        if (i==size/2)
            new_mas[i]=mas[i];
        else
            new_mas[i]=mas[i]*mas[size-i-1];
    }
    return new_mas;
}

Console.WriteLine("enter the number of array elements");
int mas1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the initial range");
int n1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the end range");
int k1 = int.Parse(Console.ReadLine()!);

int[] mas = massiv(mas1,n1,k1);
Print(mas);
int[] mass = sum_mas(mas);
Print(mass);
