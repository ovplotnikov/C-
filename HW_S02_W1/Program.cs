//Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число: ");

string? s_num1 = Console.ReadLine();

int num1 = int.Parse(s_num1);

int ThirdDigigt = num1 % 10;
int FirstDigigt = num1 / 100;
int SecondDigit = (num1-ThirdDigigt-FirstDigigt*100)/10;


Console.WriteLine("Вторая цифра: " + SecondDigit);
