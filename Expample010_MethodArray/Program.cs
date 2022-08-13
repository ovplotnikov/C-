// Использование массивов
int[] Array = { 1, 2, 3, 4, 50, 6, 7, 8, 50 };

int n = Array.Length;

int find = 50;

int index = 0;

while (index < n)
{

    if (Array[index] == find)
    {
        Console.WriteLine("Индекс элемента " + index);
        Console.WriteLine("Значение элемента " + Array[index]);
        break; //прерывает в после первого совпадения
    }
     
    //index = index+1;
    index++;
  

}