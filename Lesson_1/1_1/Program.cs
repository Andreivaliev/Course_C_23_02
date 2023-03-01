/*1.Напишите программу, которая на вход принимает два
числа и проверяет, является ли первое число квадратом
второго.*/
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
if (b*b == a)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}