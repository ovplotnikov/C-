// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


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

//Метод, который упорядочит по убыванию элементы каждой строки двумерного массива

void SortArrayRow(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (var k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    var temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
        
    }
}

Console.WriteLine("Sorted array");
Console.WriteLine();

SortArrayRow(array);
PrintArray(array);