// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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

int m = 3;
int n = 3;

int[,] FirstArray = CreateArrayWithRandomNumbers(m, n);

Console.WriteLine("First array");
Console.WriteLine();

PrintArray(FirstArray);
Console.WriteLine();



int[,] SecondArray = CreateArrayWithRandomNumbers(m, n);

Console.WriteLine("Second array");
Console.WriteLine();

PrintArray(SecondArray);
Console.WriteLine();

//Метод, который находит произведение двух матриц

void MultiplicationOfTwoArrays(int[,] FirstArray, int[,] SecondArray)
{
    int[,] MultiplicationArray = new int[m, n];

    for (var i = 0; i < FirstArray.GetLength(0); i++)
    {
        for (var j = 0; j < FirstArray.GetLength(1); j++)
        {
            for (var k = 0; k < FirstArray.GetLength(1); k++)
            {
                MultiplicationArray[i, j] += FirstArray[i, k] * SecondArray[k, j];
            }
        }
    }

    Console.WriteLine("Multiplication array");
    Console.WriteLine();

    PrintArray(MultiplicationArray);
    Console.WriteLine();
}

MultiplicationOfTwoArrays(FirstArray, SecondArray);