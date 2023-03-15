/*Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь*/
int Cou()
{
    Console.WriteLine("enter a number");
    int count=0;
    int i=0;
while(i<100)
{
    String a = Console.ReadLine()!;
    if (a == "stop")
    {
        i=100;
        break;
    }
    int b = int.Parse(a);
   
    if(b>0)
    {
        count=count+1;
    }
   
    
    i++;
}
return count;
}
int sum = Cou();
Console.WriteLine(sum);


