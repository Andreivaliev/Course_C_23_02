/* Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве*/

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
void Search(int[] mas, int a)
{
  
    for (int i = 0; i<mas.Length; i++)
    {
        if(mas[i]==a)
        {
            Console.WriteLine($"Yes, index {i}");
            return;
        }
             
        
        
    }
    Console.WriteLine("No");
}
Console.WriteLine("enter the number of array elements");
int mas1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the initial range");
int n1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the end range");
int k1 = int.Parse(Console.ReadLine()!);

int[] mas = massiv(mas1,n1,k1);
Print(mas);
Console.WriteLine("Entet a number");
int a1 = int.Parse(Console.ReadLine()!);
Search(mas,a1);
