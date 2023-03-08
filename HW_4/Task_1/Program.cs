/*Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B*/
int Degree(int a,int b)
{
    int c = 1;
    for (int i=1; i<=b; i++)
    {
        c=c*a;
    }
    return c;
}
Console.WriteLine("Entet a number");
int a1 = int.Parse(Console.ReadLine()!);
int b1 = int.Parse(Console.ReadLine()!);
int result = Degree(a1,b1);
Console.WriteLine(result);
