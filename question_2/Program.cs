// Напишите "программу, которая принимает на вход три числа и выдает максимальное из этих чисел."
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Ведите число:");
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int c=Convert.ToInt32(Console.ReadLine());
  
if(a>b && a>c)
{
    Console.Write(a);
}

if(b>a && a>c)
{
    Console.Write(b);
}

if(c>a && c>b)
{
    Console.Write(c);
}
