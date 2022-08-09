// Программа на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");

string? s_num1 = Console.ReadLine();

int num1 = int.Parse(s_num1);

for (int i = 1; i <= num1; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);