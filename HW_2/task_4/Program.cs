 /*Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.*/
void Day(int num)
{
    if(num>7 || num<1)
        Console.WriteLine("inalide value");
    else if(num > 0 & num < 6)
        Console.WriteLine("weekday");
    else 
        Console.WriteLine("weekend");
}
Console.WriteLine("enter a number from one to seven");
int a = int.Parse(Console.ReadLine()!);
Day(a);
