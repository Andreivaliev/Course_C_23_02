/*Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе
*/
int SumNum(int a)
{
    int c=0;
    
    for (int i=1; a>0 ; i++)
    {
        c=c+a%10;
        a=a/10;
    }
    return c;
}
Console.WriteLine("Enter a number");
int a1 = int.Parse(Console.ReadLine()!);
int result = SumNum(a1);
Console.WriteLine(result);
