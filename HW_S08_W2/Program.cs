// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


// Метод печатает двумерный массив
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

// Метод создает двумерный массив M x N и заполняет его случайными числами
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

Console.WriteLine("initial array");
Console.WriteLine();

PrintArray(array);
Console.WriteLine();

//Метод, который считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементо

void LargestAmountLine(int[,] array)
{
    int[] sum = new int[n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
            sum[i] += array[i, j];
           Console.WriteLine($"Sum of {i} line is {sum[i]}");
    }
    int min = sum[0];
    int minIndex = 0;
    for (int i = 0; i < n; i++)
    {
        if (sum[i] < min)
        {
            min = sum[i];
            minIndex = i;
        }
    }
    Console.WriteLine($"Line with the smallest sum is {minIndex}");
}

Console.WriteLine("Sorted array");
Console.WriteLine();

LargestAmountLine(array);