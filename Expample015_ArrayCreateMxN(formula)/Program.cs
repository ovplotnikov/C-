//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5


void PrintArray(int[,] array) {
    for (var i = 0; i < array.GetLength(0); i++) {
        for (var j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i,j]}, ");
        }
        Console.WriteLine();
    }
}

int[,] CreateArrayWithNumbers(int m, int n)
{
    int[,] result = new int[m, n];

    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (var j = 0; j < result.GetLength(1); j++)
        {
                result[i, j] = i+j;
        }
    }

    return result;
}


Console.WriteLine("Введите число строк (m)");
if(!int.TryParse(Console.ReadLine()!, out var m)) {
    Console.WriteLine("Всё плохо");
}

Console.WriteLine("Введите число столбцов (n)");
if(!int.TryParse(Console.ReadLine()!, out var n)) {
    Console.WriteLine("Всё плохо");
}


PrintArray(CreateArrayWithNumbers(m, n));
