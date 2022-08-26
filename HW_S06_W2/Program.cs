// Программа ищет точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2
//значения b1, k1, b2 и k2 вводятся с клавиатуры.


Console.WriteLine("ВВедите коэффициенты первой прямой");
Console.Write("Введите коэффициент k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ВВедите коэффициенты второй прямой");
Console.Write("Введите коэффициент k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double fX = k1 * x + b1;
Console.WriteLine("Точка пересечения прямых заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Значение x = " + x);
Console.WriteLine("Значение y = " + fX);
