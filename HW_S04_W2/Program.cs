//Программа, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Сумма цифр числа А");

Console.WriteLine("Введите число А");

var аString = Console.ReadLine();

int a = int.Parse(аString!);

int printa = a;

int sum = 0;

while (a > 0)
{
    sum = sum + (a % 10);

    a = a / 10;

}


Console.WriteLine("Сумма цифр числа " + printa + " = " + sum);