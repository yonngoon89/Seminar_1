// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int i = 1;
Console.WriteLine("введите первое число");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("четные числа от 1 до " + N);

while (i<=N)
{
    if ((i%2)==0)
    {
        Console.WriteLine(i + ",");
    }
    i++;
}

    
