// See https://aka.ms/new-console-template for more information


// Метод получает из консоли строку и преобразует ее в целое число или сообщает об ошибке

void ReadNaturalNumber(string StrValue, out int n)

{
    Console.WriteLine($"Введите число {StrValue}");
    if (!int.TryParse(Console.ReadLine()!, out n))
    {
        Console.WriteLine("Некорректный ввод");
    }
}

//Метод для вычисления функции Аккермана с помощью рекурсии

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    else
    {
        return 0;
    }
    
}


ReadNaturalNumber("M", out var m);
ReadNaturalNumber("N", out var n);

Console.WriteLine($"Функция Аккермана с параметрами {m} и {n} равна {Ackermann(m, n)}");