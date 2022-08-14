// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Проверка - является ли число палиндромом");

Console.WriteLine("Введите число");

var numString = Console.ReadLine();

int num = int.Parse(numString!);

int num1 = num;

int rev = 0;

int total = 0;

while (num > 0)
{
    rev = num % 10;
    num = num / 10;
    total = (total * 10) + rev;
  }
if (num1 == total)
{
Console.WriteLine("Число - палиндромом");
}
else
{
Console.WriteLine("Число - НЕ палиндромом");
}