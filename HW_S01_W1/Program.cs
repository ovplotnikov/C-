//Программа на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.WriteLine("Введите первое число: ");

string? s_num1 = Console.ReadLine();

int num1 = int.Parse(s_num1);

Console.WriteLine("Введите второе число: ");

string? s_num2 = Console.ReadLine();

int num2 = int.Parse(s_num2);

int max = num1;
    

if (num1 < num2)
{
    max = num2;

}

Console.WriteLine("max = " + max);