// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray(int[] collection) // Функция заполняет масиив целыми трехзначными числами
{
    int Lenght = collection.Length;
    int index = 0;
    while (index < Lenght)
    {

        collection[index] = new Random().Next(100, 1000);
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

FillArray(array);

PrintArray(array);

Console.WriteLine("______________________________________________________________________");

int count = array.Length;
int num_of_evens = 0;
int index = 0;
while (index < count)
{
    if (array[index] % 2 == 0)
    {
        num_of_evens = num_of_evens + 1;

    }
    index++;
}

Console.WriteLine("Количество четных элементов массива: " + num_of_evens);