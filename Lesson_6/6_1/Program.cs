/*Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины*/
void Triangle (int A,int B, int C)
{
    if(A<B+C & B<C+A & C<A+B)
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
}

Console.WriteLine("enter the first number");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the second number");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the third number");
int c = int.Parse(Console.ReadLine()!);

Triangle(a,b,c);