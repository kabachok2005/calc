using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

Console.WriteLine("1 сложить 2 числа");
Console.WriteLine("2 вычесть первое из второго");
Console.WriteLine("3 перемножить два числа");
Console.WriteLine("4 разделить первое на второе");
Console.WriteLine("5 возвести в степень n первое число");
Console.WriteLine("6 найти квадратный корень из числа");
Console.WriteLine("7 найти 1% от числа");
Console.WriteLine("8 найти факториал числа");
Console.WriteLine("9 выйти из программы");
Console.WriteLine("Введите действие");
int vibor = 0;
while (vibor != 9)
{
    vibor = Convert.ToInt32(Console.ReadLine());
    if (vibor == 1)
    {
        Console.WriteLine("введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите второе число");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a + b);
        Console.WriteLine("Введите действие");
    }
    if (vibor == 2)
    {
        Console.WriteLine("введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите второе число");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a - b);
        Console.WriteLine("Введите действие");
    }
    if (vibor == 3)
    {
        Console.WriteLine("введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите второе число");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a * b);
        Console.WriteLine("Введите действие");
    }
    if (vibor == 4)
    {
        Console.WriteLine("введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите второе число");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a / b);
        Console.WriteLine("Введите действие");
    }
    if (vibor == 5)
    {
        Console.WriteLine("введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите степень");
        int b = Convert.ToInt32(Console.ReadLine());
        int a2 = a;
        for (int i = 0; i < b - 1; i++)
        {
            a = a * a2;
        }
        Console.WriteLine(a);
        Console.WriteLine("Введите действие");
    }
    if (vibor == 6)
    {
        Console.WriteLine("введите число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(a));
        Console.WriteLine("Введите действие");
    }
    if (vibor == 7)
    {
        Console.WriteLine("введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a / 100);
        Console.WriteLine("Введите действие");
    }
    if (vibor == 8)
    {
        Console.WriteLine("введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());
        int c = 1;
        for (int i = 1; i != a + 1; i++)
        {
            c = c * i;
        }
        Console.WriteLine(c);
        Console.WriteLine("Введите действие");
    }
    if (vibor >9)
    {
        Console.WriteLine("Попробуйте снова");
    }
    if (vibor < 1)
    {
        Console.WriteLine("Попробуйте снова");
    }
}
Console.Clear();
Console.WriteLine("Вы вышли из программы");
