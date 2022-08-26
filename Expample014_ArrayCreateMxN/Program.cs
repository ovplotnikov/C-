//Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

void PrintArray(int[,] array) {
    for (var i = 0; i < array.GetLength(0); i++) {
        for (var j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i,j]}, ");
        }
        Console.WriteLine();
    }
}

int[,] CreateArrayWithRandomNumbers(int m, int n) {
    int[,] result = new int[m,n];

    var random = new Random();

    for (var i = 0; i < result.GetLength(0); i++) {
        for (var j = 0; j < result.GetLength(1); j++) {
            result[i,j] = random.Next(1, 100);
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


PrintArray(CreateArrayWithRandomNumbers(m, n));


