void Div(int num1, int num2)
{
    if(num1%num2==0)
         Console.WriteLine("Кратно");
    else 
        Console.WriteLine("Некратно " + num1%num2); 
}
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
Div(a,b);