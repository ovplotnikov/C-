// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] result = new int[m, n];
    var random = new Random();
    for (var i = 0; i < result.GetLength(0); i++)
        for (var j = 0; j < result.GetLength(1); j++)
            result[i, j] = random.Next(1, 10);
    return result;
}

void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {

            Dictionary<int, int> CountFrequency(int[,] array)
            {
                Dictionary<int, int> counters = new Dictionary<int, int>();

                foreach (int i in array)
                    if (counters.ContainsKey(i))
                        counters[i]++;
                    else
                        counters.Add(i, 1);

                return counters;
            }
        }
    }
}

void PrintDictionary(Dictionary<int, int> dictionary)
{
    foreach (var item in dictionary)
    {
        Console.WriteLine($"{item.Key} встречается {item.Value} раз");
    }
}

Console.WriteLine("Введите число строк (m)");
if (!int.TryParse(Console.ReadLine()!, out var m))
{
    Console.WriteLine("Всё плохо");
}

Console.WriteLine("Введите число столбцов (n)");
if (!int.TryParse(Console.ReadLine()!, out var n))
{
    Console.WriteLine("Всё плохо");
}

var array = CreateArrayWithRandomNumbers(m, n);
PrintArray(array);

var result = CountFrequency(array);

PrintDictionary(result);