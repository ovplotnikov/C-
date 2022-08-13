void FillArray(int[] collection)
{
    int Lenght = collection.Length;
    int index = 0;
    while (index < Lenght)
    {

        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;

    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int position = -1;
    int index = 0;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;

}

int[] array = new int[10]; //Создали целочисленный массив из 10 элементов

FillArray(array);

PrintArray(array);

Console.WriteLine("________________________________________________________________________");


int pos = IndexOf(array, 4);
Console.WriteLine (pos);