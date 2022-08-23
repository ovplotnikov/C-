//Программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Расстояние между ними в 3D пространстве");

Console.WriteLine("Введите координату x точки A");

var xaString = Console.ReadLine();

double xa = double.Parse(xaString!);

Console.WriteLine("Введите координату y точки A");

var yaString = Console.ReadLine();

double ya = double.Parse(yaString!);

Console.WriteLine("Введите координату z точки A");

var zaString = Console.ReadLine();

double za = double.Parse(zaString!);

Console.WriteLine("Введите координату x точки B");

var xbString = Console.ReadLine();

double xb = double.Parse(xbString!);

Console.WriteLine("Введите координату y точки B");

var ybString = Console.ReadLine();

double yb = double.Parse(ybString!);

Console.WriteLine("Введите координату z точки B");

var zbString = Console.ReadLine();

double zb = double.Parse(zbString!);

//double d = sqrt((xb - xa) ^ 2 + (yb - ya) ^ 2 + (zb - za) ^ 2);


int power2 = 2;


double d1 = xb - xa;

d1 = Math.Pow(d1, power2);


double d2 = yb - ya;

d2 = Math.Pow(d2, power2);


double d3 = zb - za;

d3 = Math.Pow(d3, power2);


double d = d1 + d2 + d3;


d = Math.Sqrt(d);

Console.WriteLine("Расстояние между двумя точками D = " + d);