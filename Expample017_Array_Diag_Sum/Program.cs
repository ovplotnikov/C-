/* Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали 
(с индексами (0,0); (1;1) и т.д. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12 */


int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] result = new int[m, n];
    var random = new Random();
    for (var i = 0; i < result.GetLength(0); i++)
        for (var j = 0; j < result.GetLength(1); j++)
            result[i,j] = random.Next(1, 10);
    return result;
}
void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]}, ");
        Console.WriteLine();
    }
}
int DiagonalSum (int [,] array)
{
    int Sum = 0;
    for (var i = 0; i < array.GetLength(0); i++)
        for (var j = 0; j < array.GetLength(1); j++)
            if (i==j) Sum += array [i,j];
    return Sum;
}
Console.WriteLine("Введите число строк (m)");
if (!int.TryParse(Console.ReadLine()!, out var m)) Console.WriteLine("Всё плохо");
Console.WriteLine("Введите число столбцов (n)");
if (!int.TryParse(Console.ReadLine()!, out var n)) Console.WriteLine("Всё плохо");
int [,] array =CreateArrayWithRandomNumbers(m, n);
PrintArray (array);
Console.WriteLine ();
Console.WriteLine ("Сумма элементов находящихся на главной диагонали = " + DiagonalSum (array));

