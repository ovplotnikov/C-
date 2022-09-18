// Нахождение факториала с помощью рекурсии

double Factorial (double n)
{
    if (n == 0)
        return 1;
    else
        return n * Factorial (n - 1);
}

Console.WriteLine ("Вычисление факториала. Введите число:");
double n = Convert.ToDouble (Console.ReadLine ());

for (int i = 0; i < n; i++)
    Console.WriteLine ("{0}! = {1}", i, Factorial (i));
Console.WriteLine ("Факториал числа {0} равен {1}", n, Factorial (n));
