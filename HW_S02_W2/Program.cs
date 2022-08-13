// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите любое целое число: ");

string? s_num1 = Console.ReadLine();

int num1 = int.Parse(s_num1);

if (num1 < 100)
{
    Console.WriteLine ("Третьей цифры числа нет");
}

else
{
while (num1 > 1000)
{
    num1 = num1/10;
    
}
int ThirdDigigt = num1 % 10;
Console.WriteLine ("Третья цифра числа " + ThirdDigigt);
}