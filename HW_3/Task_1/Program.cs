/*Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.*/
void Palindrome(int a)
{
    if ( (a >= 100000)|| (a < 10000))
        Console.WriteLine("not a five-digit number");
    else if ( (a/10000 == a%10) && (a/1000%10 == a%100/10))
        Console.WriteLine("polydrome");
    else
        Console.WriteLine("not a polydrome");
}
Console.WriteLine("enter a five-digit number");
Palindrome(int.Parse(Console.ReadLine()!));
