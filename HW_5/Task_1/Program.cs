/* Задача 1: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.*/
void Print (int[] arr)
{
    int size=arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] mass(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++ )
    {
        arr[i]=new Random().Next(100,1000);
    }
    return arr;
}

int CountEven(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0)
            count+=1;
    }
    return count;
}

Console.WriteLine("enter the number of array elements");
int lenght = int.Parse(Console.ReadLine()!);

int[] mas = mass(lenght);
Print(mas);
int result = CountEven(mas); 
Console.WriteLine(result);


