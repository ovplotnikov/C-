// Задайте массив вещественных чисел.  
// Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(int[] collection) // Функция заполняет массив случайными целыми числами от -100 до 100
{
    int Lenght = collection.Length;
    int index = 0;
    while (index < Lenght)
    {

        collection[index] = new Random().Next(-100, 101);
        index++;
    }
}

void PrintArray(int[] col) // Функция выводит в консоль все элементы массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;

    }
}

int[] array = new int[10]; //Создали целочисленный массив из 10 элементов

Console.WriteLine("Элементы случайного массива:");
FillArray(array);

PrintArray(array);

Console.WriteLine("______________________________________________________________________");

int max_array = array[0]; //Ищем максимальный элемент массива
int imax = 0;

while (imax < array.Length)
{
    if (array[imax] > max_array)
    {
        max_array = array[imax];
    }
    imax ++;
}
Console.WriteLine("Максимальный элемент массива: " + max_array);

int min_array = array[0]; //Ищем минимальный элемент массива
int imin = 0;

while (imin < array.Length)
{
    if (array[imin] < min_array)
    {
        min_array = array[imin];
    }
    imin ++;
}
Console.WriteLine("Минимальный элемент массива: " + min_array);

int result = max_array - min_array;

Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + result);
