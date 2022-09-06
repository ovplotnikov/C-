//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void PrintArray(int[,,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (var k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}, ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] CreateArrayWithRandomNumbers(int m, int n, int p)
{
    int[,,] array = new int[m, n, p];

    var random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (var k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = random.Next(1, 10);
            }
        }
    }

    return array;
}


int m = 2;
int n = 2;
int p = 2;

int[,,] FirstArray = CreateArrayWithRandomNumbers(m, n, p);

Console.WriteLine("First array");
Console.WriteLine();

PrintArray(FirstArray);
Console.WriteLine();

//Метод, который построчно выводит элементы массива, добавляя индексы каждого элемента.
void PrintIndexArrayLine(int[,,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (var k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Index Array Line");
Console.WriteLine();

PrintIndexArrayLine(FirstArray);
Console.WriteLine();