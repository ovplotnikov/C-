//Программа принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");

string? s_num1 = Console.ReadLine();

int num1 = int.Parse(s_num1);

Console.WriteLine("Введите второе число: ");

string? s_num2 = Console.ReadLine();

int num2 = int.Parse(s_num2);

Console.WriteLine("Введите третье число: ");

string? s_num3 = Console.ReadLine();

int num3 = int.Parse(s_num3);

int max = num1;
    

if (num1 < num2)
{
    max = num2;

}

if (num2 < num3)
{
    max = num3;

}
Console.WriteLine("max = " + max);