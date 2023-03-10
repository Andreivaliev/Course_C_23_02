/*Напишите программу замена элементов массива:
положительные элементы замените на соответствующие
отрицательные, и наоборот*/
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

int[] replacement(int[] mass)
{
    int size = mass.Length;
    for (int i =0 ; i<size; i++)
        mass[i]=mass[i]*-1;
    return mass;
}
Console.WriteLine("enter the number of array elements");
int mas1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the initial range");
int n1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the end range");
int k1 = int.Parse(Console.ReadLine()!);

int[] mas = massiv(mas1,n1,k1);
Print(mas);
int[] new_mas = replacement(mas);
Print(new_mas);