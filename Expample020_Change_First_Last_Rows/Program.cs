//Напишите программу, которая поменяет местами первую и последнюю строку массива.



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


int[,] array = CreateArrayWithRandomNumbers(m, n);

PrintArray(array);


int[,] ChangeRowsAndColumns(int[,] array) 
{ 
    int[,] result = new int[array.GetLength(1), array.GetLength(0)]; 
    for (int i = 0; i < result.GetLength(0); i++) 
    { 
        for (int j = 0; j < result.GetLength(1); j++) 
        { 
            result[i, j] = array[j, i]; 
        } 
    } 
    return result; 
} 

PrintArray(ChangeRowsAndColumns(array);