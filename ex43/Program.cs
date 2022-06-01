// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 0,5)
string TheEquation(double b1, double k1, double b2, double k2)
{
    string result = string.Empty;
    double x = 0;
    double y = 0;
    x = (b2 - b1) / (k1 - k2);
    y = (k1 * x) + b1;
    result = $"({Math.Round(x,2)}; {Math.Round(y,2)})";
    return result;
}
Console.Write("Введите значения b1, k1, b2 и k2 через запятую: ");
double[] array = Console.ReadLine().Split(',').Select(x => double.Parse(x)).ToArray();
Console.WriteLine(TheEquation(array[0],array[1],array[2],array[3]));