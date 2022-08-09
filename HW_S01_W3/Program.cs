//Программа на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");

string? s_num1 = Console.ReadLine();

int num1 = int.Parse(s_num1);

int div = num1%2;

string answer = ("Число четное");

if (div > 0)
{
    answer = ("Число нечетное");
}

Console.WriteLine(answer);