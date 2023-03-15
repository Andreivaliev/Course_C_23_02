/*Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.*/
void Fib(int a)
{
    int first_num = 0;
    int second_num = 1;
    for (int i = 0; i < a; i ++)
    {
        Console.Write(first_num + " ");
        (first_num, second_num) = (second_num, first_num + second_num );
    }
}
int A = int.Parse(Console.ReadLine()!);
Fib(A);