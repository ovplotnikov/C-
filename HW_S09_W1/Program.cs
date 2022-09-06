//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.


// Метод получает из консоли строку и преобразует ее в целое число или сообщает об ошибке

void ReadNaturalNumber(string StrValue, out int n)

{
    Console.WriteLine($"Введите число {StrValue}");
    if (!int.TryParse(Console.ReadLine()!, out n))
    {
        Console.WriteLine("Некорректный ввод");
    }
}

//Метод который выведет все натуральные числа в промежутке от M до N.

void PrintNaturalNumbers(int m, int n)
{
    Console.Write($"Натуральны числа в промежутке от {m} до {n}: ");
   for (int i = m; i<=n; i++)
   {
    Console.Write($"{i} ");
   }
}


ReadNaturalNumber("M", out var m);
ReadNaturalNumber("N", out var n);


PrintNaturalNumbers(m, n);
