//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

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

void PrintStringArray(string[,] array)
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

// Метод  заполняет массив по спирали
int[,] CreateSpiralArray(int m, int n)
{
    int[,] array = new int[m, n];

    int counter = 1;
    int i = 0;
    int j = 0;

    while (counter <= m * n)
    {
        while (j < n && array[i, j] == 0)
        {
            array[i, j] = counter;
            counter++;
            j++;
        }
        j--;
        i++;

        while (i < m && array[i, j] == 0)
        {
            array[i, j] = counter;
            counter++;
            i++;
        }
        i--;
        j--;

        while (j >= 0 && array[i, j] == 0)
        {
            array[i, j] = counter;
            counter++;
            j--;
        }
        j++;
        i--;

        while (i >= 0 && array[i, j] == 0)
        {
            array[i, j] = counter;
            counter++;
            i--;
        }
        i++;
        j++;
    }

    return array;
}

int m = 4;
int n = 4;

int[,] FirstArray = CreateSpiralArray(m, n);

Console.WriteLine("First array");
Console.WriteLine();

PrintArray(FirstArray);
Console.WriteLine();

string[,] SecondArray = new string[m, n];
for (var i = 0; i < SecondArray.GetLength(0); i++)
{
    for (var j = 0; j < SecondArray.GetLength(1); j++)
    {
        SecondArray[i, j] = $"{FirstArray[i, j]}";
        if (SecondArray[i, j].Length == 1)
        {
            SecondArray[i, j] = $"0{SecondArray[i, j]}";
        }
    }
}


Console.WriteLine("Second array");
Console.WriteLine();

PrintStringArray(SecondArray);
Console.WriteLine();