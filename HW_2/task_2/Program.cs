/* Напишите программу, которая выводит
случайное трёхзначное число и удаляет вторую цифру
этого числа*/
void SecondDelete(int num)
{
    if (num<1000 & num>=100)
        {
            Console.WriteLine(num/100*10+num%10);
        }
    else
        Console.WriteLine("invalid value");
}
Console.WriteLine("enter a three-digit number");
int a = int.Parse(Console.ReadLine()!);
SecondDelete(a);
