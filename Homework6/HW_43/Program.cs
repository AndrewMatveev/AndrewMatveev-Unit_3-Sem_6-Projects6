// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double EnterParamLine(string txt)
{
    System.Console.Write(txt);
    double NameLine = Convert.ToDouble(System.Console.ReadLine());
    return NameLine;
}

void PrintParamA(string txt, double k, double b, out string funA)
{
    System.Console.Write(txt);
    funA = $"{k * 1} * x + {b * 1}";
    System.Console.WriteLine($"\n y = {funA}");
}
void PrintParamB(string txt, double k, double b, out string funB)
{
    System.Console.Write(txt);
    funB = $"{k * 2} * x + {b * 2}";
    System.Console.WriteLine($"\n y = {funB}");
}

void FindYX(double k1, double b1, double k2, double b2)
{
    if (k1 == k2 && b1 == b2)
    {
        System.Console.WriteLine("Прямые налагаются друг на друга и пересекаются по всей длинне");
    }
    else if ((k1 == k2) && (b1 != b2))
    {
        System.Console.WriteLine("Прямые параллельны и не пересекаются");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y2 = k2 * x + b2;
        System.Console.WriteLine($"Прямые пересекаются в точках y = {y2}, x = {x}");
    }
}


Console.Clear();
double k1 = EnterParamLine("Введите парам. k для первой прямой: ");
double b1 = EnterParamLine("Введите парам. b для первой прямой: ");

PrintParamA("Формула первой прямой: ", k1, b1, out string funA);


double k2 = EnterParamLine("Введите парам. k для второй прямой: ");
double b2 = EnterParamLine("Введите парам. b для второй прямой: ");

PrintParamB("Формула второй прямой: ", k2, b2, out string funB);

FindYX(k1, b1, k2, b2);