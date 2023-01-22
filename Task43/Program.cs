// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Enter coordinates b1, k1, b2, k2:");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());

double ToFindCoordinatesX(double i1, double j1, double i2, double j2)
{
    double x = 0;
    x = (i2 - i1) / (j1 - j2);
    return x;
}

double ToFindCoordinatesY(double i1, double j1, double i2, double j2)
{
    double y = (j1 * (i2 - i1) / (j1 - j2) + i1);
    return y;
}

double coordinatesX = ToFindCoordinatesX(b1, k1, b2, k2);
double coordinatesY = ToFindCoordinatesY(b1, k1, b2, k2);
Console.WriteLine($"The point of intersection of two lines: b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({coordinatesX};{coordinatesY})");