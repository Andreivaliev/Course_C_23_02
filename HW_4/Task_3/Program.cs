/*Напишите программу, которая задаёт массив
 случайными числами и выводит их на экран.
Оформите заполнение массива и вывод в виде функции */
void massiv(int mas,int n, int k)
{
    int [] numbers= new int [mas];
    for (int i=0; i<mas; i++)
    {
        numbers[i] = new Random().Next(n,k+1);
        Console.WriteLine(numbers[i]);
    }
}
Console.WriteLine("enter the number of array elements");
int mas1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the initial range");
int n1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the end range");
int k1 = int.Parse(Console.ReadLine()!);
massiv(mas1,n1,k1);
