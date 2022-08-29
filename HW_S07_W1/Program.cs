// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:F2} ");
        }
        Console.WriteLine();
    }
}

double[,] CreateArrayWithRandomNumbers(int m, int n)
{
    double[,]  array = new double[m, n];
    var random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.NextDouble()*10-5;
        }
    }
    return array;

}




Console.WriteLine("Введите число строк (m)");
if(!int.TryParse(Console.ReadLine()!, out var m)) {
    Console.WriteLine("Некорртеный ввод");
}

Console.WriteLine("Введите число столбцов (n)");
if(!int.TryParse(Console.ReadLine()!, out var n)) {
    Console.WriteLine("Некорртеный ввод");
}

PrintArray(CreateArrayWithRandomNumbers(m, n));