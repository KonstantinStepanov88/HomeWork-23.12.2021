// Найти расстояние между точками в пространстве 2D

Console.WriteLine("Введите координаты первой точки X1 и Y1: ");
double X1 = int.Parse(Console.ReadLine());
double Y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки X2 и Y2: ");
double X2 = int.Parse(Console.ReadLine());
double Y2 = int.Parse(Console.ReadLine());
Double dist = Math.Sqrt(((X2 - X1) * (X2 - X1)) + ((Y2 - Y1)*(Y2 - Y1)));
Console.WriteLine("Расстояние между точками = " + dist);
