// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

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

int count = array.Length;
int sum_of_odd_index = 0;
int index = 1;
while (index < count)
{
    if (index % 2 != 0)
    {
        sum_of_odd_index = sum_of_odd_index + array[index];
        //Console.WriteLine("index " + index);
        //Console.WriteLine("sum_of_odd_index " + sum_of_odd_index);
        //Console.WriteLine("array[index] " + array[index]);

    }
    index++;
}

Console.WriteLine("Сумма всех нечетных элементов массива: " + sum_of_odd_index);