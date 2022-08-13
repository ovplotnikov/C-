// Нахождение максимального числа с испольованием методов С#
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2> result) result=arg2;
    if(arg3> result) result=arg3;
    return result;
}


int a1 = 23;
int b1 = 35;
int c1 = 132;
int a2 = 55;
int b2 = 99;
int c2 = 23;
int a3 = 56;
int b3 = 78;
int c3 = 323;

//int max1 = Max(a1,b1,c1);
//int max2 = Max(a2,b2,c2);
//int max3 = Max(a3,b3,c3);
int max = Max(Max(a1,b1,c1), Max(a2,b2,c2), Max(a3,b3,c3));// Одна строка вместо трех предыдущих
Console.WriteLine(max);