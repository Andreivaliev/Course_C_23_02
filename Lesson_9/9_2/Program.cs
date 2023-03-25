/*Задайте значения M и N. Напишите программу, которая
рекурсивно выведет все натуральные числа в промежутке от M до N.*/
void SeriesNums(int M,int N)
{
    if(M-1==N) return;
    SeriesNums(M,N-1);
    Console.Write($"{N} ");
}
    SeriesNums(int.Parse(Console.ReadLine()!),int.Parse(Console.ReadLine()!));
