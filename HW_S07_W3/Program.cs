/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


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
            array[i, j] = random.Next(1, 10);
        }
    }

    return array;
}


int m = 4;
int n = 4;


int[,] array = CreateArrayWithRandomNumbers(m, n);

PrintArray(array);

double sum = 0;

for (var i = 0; i < array.GetLength(0); i++)
{
    for (var j = 0; j < array.GetLength(1); j++)
    {
        
        
        sum = sum + array[j, i];
        double middle = sum / array.GetLength(1);
        if (j == array.GetLength(1) - 1)
        {
            Console.WriteLine($"Среднее арифметическое столбца {i}: {middle}");
            sum = 0;
        }
        
                

    }
}
