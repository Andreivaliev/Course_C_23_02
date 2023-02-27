/*
Напишите программу, которая будет выдавать
название дня недели 
*/
Console.WriteLine("Введите ваше число");

int a = int.Parse(Console.ReadLine()!);
if (a == 1)
{
   Console.WriteLine("Mondey"); 
}
else if (a == 2)
{
   Console.WriteLine("Thuesday");
}
else if (a == 3)
{
   Console.WriteLine("Wednesday");
}
else if (a == 4)
{
   Console.WriteLine("Thursday");
}
else if (a == 5)
{
   Console.WriteLine("Friday");
}
else if (a == 6)
{
   Console.WriteLine("Saturday");
}
else if (a == 7)
{
   Console.WriteLine("Sunday");
}
else
{
   Console.WriteLine("Error");
}
