//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/* int a = 0;
int i = 0;
char b = ' ';

Console.WriteLine("Введите символ и нажмите <Enter>");
Console.WriteLine("Для завершения нажмите точку '.' и нажмите <Enter>");

do
{
    Console.Write("-> ");
    string s = Console.ReadLine();
    Int32.TryParse(s, out a);
    char.TryParse (s, out b);
    

    //a = Convert.ToDouble(s);
    if (a > 0)
    {
        i++;
    }
    Console.WriteLine("Чисел больше 0 уже " + i);
}
while (b != '.');

Console.WriteLine("Было введено чисел, которые больше  0: " + i); */

int count = 0;
string str;
Console.WriteLine("Введите символ и нажмите <Enter>");
Console.WriteLine("Для завершения нажмите точку '.' и нажмите <Enter>");
do
{
Console.Write("-> ");
str = Console.ReadLine()!;
if (int.TryParse(str, out int number))
{
if (number > 0)
{
count++;
}
}
Console.WriteLine("Чисел больше 0 уже " + count);
}
// значение не равно точке и не пустое
while (!str.Equals('.') && !string.IsNullOrEmpty(str));
Console.WriteLine("Было введено чисел, которые больше 0: " + count);