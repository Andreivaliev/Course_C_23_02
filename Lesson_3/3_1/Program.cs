// 1
void Quarters(int x, int y)
{
    if (x==0 || y==0) 
    Console.WriteLine("x or y =0");
    else if (x>0 && y>0)
    Console.WriteLine(1);
    else if (x<0 && y>0)
    Console.WriteLine(2);  
    else if (x<0 && y<0)
    Console.WriteLine(3); 
    else if (x>0 && y<0)
    Console.WriteLine(4); 

}
Quarters(int.Parse(Console.ReadLine()!),int.Parse(Console.ReadLine()!));