// 3
void Div(int n)
{
    int i=1;
    while (n>=i)
    {
        Console.WriteLine(Math.Pow(i,2));
        i++;
    }
}
Div(int.Parse(Console.ReadLine()!));