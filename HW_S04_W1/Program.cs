//Цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Возведение числа A в натуральную степень B");

Console.WriteLine("Введите число А");

var аString = Console.ReadLine();

int a = int.Parse(аString!);

Console.WriteLine("Введите число B");

var bString = Console.ReadLine();

int b = int.Parse(bString!);

int print_b = b;

int result = 1;

while (b > 0)
{
    b = b - 1;
    
    result = result * a;
        
}
Console.WriteLine("Число " + a + " в степени числа " + print_b + " = " + result);