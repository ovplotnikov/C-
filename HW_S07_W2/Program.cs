/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine();
    }
}

int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] array = new int[m, n];

    var random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 100);
        }
    }

    return array;
}

int m = 4;
int n = 4;
int NotFound = 0;

int[,] array = CreateArrayWithRandomNumbers(m, n);

PrintArray(array);

Console.WriteLine("Введите число для поиска среди элементов массива ");
if (!int.TryParse(Console.ReadLine()!, out var ArrayFindNumber))
{
    Console.WriteLine("Некорректный ввод");
}

for (var i = 0; i < array.GetLength(0); i++)
{
    for (var j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] != ArrayFindNumber)

        {
            NotFound = 1;
        }

        else if (array[i, j] == ArrayFindNumber)

        {
            Console.WriteLine($"Число {ArrayFindNumber} найдено в позиции {i}, {j}");
            return;
        }


    }
}

if (NotFound == 1)
{
    Console.WriteLine($"Число {ArrayFindNumber} не найдено в массиве");
}