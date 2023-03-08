/* Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N */

int MultiplicationNum(int num)
{
    int all_mul = 1;
    for (int i=1; i <=num; i++)
        all_mul*=i;
    return all_mul;
}
int A = int.Parse(Console.ReadLine()!);
int result = MultiplicationNum(A);
Console.WriteLine(result);
