// Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели (от 1 до 7): ");

string? s_num1 = Console.ReadLine();

int num1 = int.Parse(s_num1);

if (num1 > 0 & num1 < 8)
{

if (num1 == 6 | num1 == 7)
{
    Console.WriteLine ("Это выходной день");
}
else
{
    Console.WriteLine ("Это будний день");
}
}

else
{
    Console.WriteLine ("Некорректный ввод, введите целое число от 1 до 7");
}