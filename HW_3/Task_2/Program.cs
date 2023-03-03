/*Напишите программу,которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.*/
double Dist(double x1, double y1, double z1, double x2, double y2, double z2, int k)
{
    return  Math.Round(Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z2,2)),k);
}
Console.WriteLine("enter the coordinates of the first point");
int a1 = int.Parse(Console.ReadLine()!);
int b1 = int.Parse(Console.ReadLine()!);
int c1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the coordinates of the second point");
int a2 = int.Parse(Console.ReadLine()!);
int b2 = int.Parse(Console.ReadLine()!);
int c2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("the rounding sign of the number");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(Dist(a1,b1,c1,a2,b2,c2,n));
