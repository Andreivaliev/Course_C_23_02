/*
Напишите программу, которая принимает
на вход три числа и выдаёт максимальное из этих
*/
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine()!);
int max = a;
if (max<b)
{
  max=b;
}
if (max<c)
{
    max=c;
}
Console.WriteLine($"max={max}");
