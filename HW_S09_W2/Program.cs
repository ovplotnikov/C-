//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


// Метод получает из консоли строку и преобразует ее в целое число или сообщает об ошибке

void ReadNaturalNumber(string StrValue, out int n)

{
    Console.WriteLine($"Введите число {StrValue}");
    if (!int.TryParse(Console.ReadLine()!, out n))
    {
        Console.WriteLine("Некорректный ввод");
    }
}

//Метод который выведет сумму всех натуральных числ в промежутке от M до N. (Цикл for)

void PrintNaturalNumbers(int m, int n)
{
    Console.Write($"Сумма натуральных чисел в промежутке от {m} до {n}: ");
    int sum = 0;
    for (int i = m; i <= n; i++)
    {
        sum += i;
    }
    Console.Write($"{sum} ");
}

//Метод который выведет сумму всех натуральных числ в промежутке от M до N. (Математическая формула суммы арифметической прогрессии)

void PrintNaturalNumbersMath(int m, int n)
{
    int S = (2 * m + (n - m)) / 2 * (n - m + 1);
    Console.WriteLine();
    Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n}: {S}");
}

ReadNaturalNumber("M", out var m);
ReadNaturalNumber("N", out var n);

PrintNaturalNumbers(m, n);
PrintNaturalNumbersMath(m, n);