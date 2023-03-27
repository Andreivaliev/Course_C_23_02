/* Задайте значения M и N. Напишите программу, которая выведет все
чётные натуральные числа в промежутке от M до N с помощью рекурсии.
*/
void EvenNums(int M,int N)
{
    if (N%2==1)
    {
       EvenNums(M,N-1); 
    }
    else
    {
    if((M-1==N)||(M-2==N)) return;
    EvenNums(M,N-2);
    Console.Write($"{N} ");
    }
}
   EvenNums(int.Parse(Console.ReadLine()!),int.Parse(Console.ReadLine()!));
