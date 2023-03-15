/*Напишите программу, которая будет преобразовывать
десятичное число в двоичное.*/
String ConvertBin(int num)
{
    string result = "";
    while(num>0)
    {
        result=num%2+result;
        num=num/2;
    }
    return result;
}
Console.WriteLine("enter the  number");
int a = int.Parse(Console.ReadLine()!);
string ResultEnd = ConvertBin(a);
Console.WriteLine(ResultEnd);