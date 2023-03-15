/* Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый - на последнем и т.д.)*/
void Print (int [] arr)
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
void RevMas(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size/2 ; i++)
    {
        (arr[i],arr[size-i-1])=(arr[size-i-1],arr[i]);
    } 
}

Console.WriteLine("enter the number of array elements");
int mas1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the initial range");
int n1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the end range");
int k1 = int.Parse(Console.ReadLine()!);

int[] mas = mass(mas1,n1,k1);
Print(mas);
RevMas(mas);
Print(mas);