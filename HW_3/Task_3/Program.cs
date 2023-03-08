// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Div(int n)
{
    Console.WriteLine("answer");
    int i=1;
    while (n>=i)
    {
        Console.WriteLine(Math.Pow(i,3));
        i++;
    }
}
Console.WriteLine("enter a number");
Div(int.Parse(Console.ReadLine()!));

