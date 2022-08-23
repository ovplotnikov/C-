//Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Таблица кубов чисел от 1 до N");

Console.WriteLine("Введите число N");

var nString = Console.ReadLine();

double n = int.Parse(nString!);
double power3 = 3;
Console.WriteLine(Math.Pow(n, power3));

while (n > 1)
{
    n = n - 1;
    Console.WriteLine(Math.Pow(n, power3));
}