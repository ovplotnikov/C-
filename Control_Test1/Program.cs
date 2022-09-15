//Программа, которая из массива строк формирует массив из строк, длина которых меньше, либо равна 3 символа.



void CreateStringArray(out string[] array) //Метод получает одномерный массив строк из консоли
{
    Console.WriteLine("Введите количество элементов массива");
    int.TryParse(Console.ReadLine()!, out var n);
    array = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        array[i] = Console.ReadLine()!;
    }
}

void PrintStringArray(string[] array) //Метод выводит одномерный массив строк
{
    Console.WriteLine("Выборка из первоначального массива по заданным условиями:");
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
}

void CreateStringArrayLess3(out string[] array) //Метод создает массив из строк, длина которых меньше, либо равна 3 символа
{
    CreateStringArray(out var array1);
    var array2 = new string[array1.Length];
    int j = 0;
    foreach (var item in array1)
    {
        if (item.Length <= 3)
        {
            array2[j] = item;
            j++;
        }
    }
    array = new string[j];
    for (int i = 0; i < j; i++)
    {
        array[i] = array2[i];
    }
}

void Main()
{
    CreateStringArrayLess3(out var array);
    PrintStringArray(array);
}

Main ();