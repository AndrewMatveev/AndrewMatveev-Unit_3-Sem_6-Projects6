// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 44 -> 101100
// 3  -> 11
// 2  -> 10

void EnterNumber(string txt, out double IntPart, out double FractPart)
{
    System.Console.Write(txt);
    IntPart = Convert.ToDouble(Console.ReadLine())!;
    FractPart = Math.Round(IntPart % Convert.ToInt32(IntPart), 6);
}


void Сonverting(double IntPart, double FractPart, out string IntPartBin, out string FractPartBin)
{
    IntPartBin = "";
    FractPartBin = "";
    int IntPartTemp = Convert.ToInt32(IntPart);
    while (IntPartTemp >= 1)
    {
        IntPartBin = string.Concat(IntPartBin, Convert.ToString(IntPartTemp % 2));
        IntPartTemp = IntPartTemp / 2;
    }
    IntPartBin = ReverseString(IntPartBin);

    if (FractPart != 0)
    {
        FractPartBin = ","; // "," для сцепки при выводе
        double FractPartTemp = FractPart;  // System.Console.WriteLine("first " + FractPartTemp + "\t" + "\t" + FractPartBin); // Print Debug info
        FractPartTemp = FractPartTemp * 2;
        for (int i = 0; i < 20; i++)
        {
            if (FractPartTemp < 1)
            {
                FractPartBin = string.Concat(FractPartBin, "0");
                FractPartTemp = FractPartTemp * 2;  // System.Console.WriteLine("If " + FractPartTemp + "\t" + "\t" + FractPartBin); // Print Debug info
            }
            else
            {
                FractPartBin = string.Concat(FractPartBin, "1");
                FractPartTemp = FractPartTemp - 1;
                FractPartTemp = FractPartTemp * 2;  // System.Console.WriteLine("El " + FractPartTemp + "\t" + "\t" + FractPartBin); // Print Debug info
            }
        }
        // System.Console.WriteLine(FractPartBin);
    }

}


string ReverseString(string str) // Нормально работающее разворачивание строки
{
    char[] strReverse = str.ToCharArray();
    Array.Reverse(strReverse);
    str = new string(strReverse);
    return str;
}







System.Console.Clear();

EnterNumber("Введите десятичное число: ", out double IntPart, out double FractPart);

Сonverting(IntPart, FractPart, out string IntPartBin, out string FractPartBin);
System.Console.WriteLine($"Двоичная запись числа: {IntPartBin + FractPartBin} \n \n");



