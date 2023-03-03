// 1_1
void Quar(int t)
{
    if ( (t>4) || (t< 1)) 
    Console.WriteLine("error");
    else if (t==1)
    Console.WriteLine("x>0; y>0");
    else if (t==2)
    Console.WriteLine("x<0; y>0");  
    else if (t==3)
    Console.WriteLine("x<0; y<0"); 
    else
    Console.WriteLine("x>0; y<0"); 
    

}
Quar(int.Parse(Console.ReadLine()!));