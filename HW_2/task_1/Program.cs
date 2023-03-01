/* Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа*/
Console.WriteLine("enter a three-digit number");
void SecondNumber(int num)
{
int n=0;
    if(num > 0)
        n=num;
    else
        n=-num;
 Console.WriteLine("Second " + n/10%10);
}
int a = int.Parse(Console.ReadLine()!);
if ((a<1000 & a >=100)||(a> -1000 & a <= -100))
    SecondNumber(a);
else
    Console.WriteLine("invalid value");
