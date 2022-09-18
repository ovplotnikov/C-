// Вычисление чисел Фибоначчи до заданного порядка
Console.WriteLine("Введите порядок чисел Фибоначчи:");

int Fibonacci (int n)
{
    if (n == 0 || n == 1)
    {
        return 1;
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}

double n = double.Parse(Console.ReadLine());

for (int i = 0; i <= n; i++)
{
    Console.WriteLine($"{i}-е число Фибоначчи: {Fibonacci(i)}");
}
