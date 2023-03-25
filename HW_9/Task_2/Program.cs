/*Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N с помощью рекурсии.*/
int SumNum(int M,int N)
{
    if(M==N) return M;
    return SumNum(M,N-1)+N;
}
 int sum = SumNum(int.Parse(Console.ReadLine()!),int.Parse(Console.ReadLine()!));
Console.WriteLine(sum);
