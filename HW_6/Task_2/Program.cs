/*Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 *
x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем*/
void Point(int b1, int k1, int b2, int k2 )
{
    double x = 0;
    double y = 0;
    if((k1==k2)&&(b1==b2))
    {
        Console.WriteLine("infinite number of points");
    }
    else if ((k1==k2)&&(b1!=b2))
    {
         Console.WriteLine("no dots");
    }
    else
        {
            x=(b1-b2)/(k2-k1);
            y=k1*x+b1;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
}
Console.WriteLine("enter the  number");
int b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the  number");
int k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the  number");
int b2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the  number");
int k2 = int.Parse(Console.ReadLine()!);
Console.WriteLine();

Point(b1,k1,b2,k2);
