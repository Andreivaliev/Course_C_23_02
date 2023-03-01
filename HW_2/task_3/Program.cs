/*Напишите программу, которая выводит третью
цифру заданного числа или сообщает, что третьей цифры
нет.*/
void ThirdNumber(int num)
{
    if(num<100 & num > -100)
        Console.WriteLine("there is no third digit");
    else 
     {
        int i=1;
        while((num>1000*i)||(num < -1000*i))
        {
            i=i*10;
        }
        Console.WriteLine(num/i%10);
     }

}
Console.WriteLine("enter a number greater than one hundred");
int a = int.Parse(Console.ReadLine()!);
ThirdNumber(a);