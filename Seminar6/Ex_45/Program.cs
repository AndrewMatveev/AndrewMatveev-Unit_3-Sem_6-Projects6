//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования. 1:11:48 - что значит поэлементное.

double[] EnterNumbers(string txt)
{
    System.Console.Write(txt);
    return Console.ReadLine()!.Split(";").Select(double.Parse).ToArray();
}

double[] CopyArr(double[] Arr)
{
    double[] ArrCopy = new double[Arr.Length];
    for (int i = 0; i < Arr.Length; i++)
    {
        ArrCopy[i] = Arr[i];
    }
    return ArrCopy;
}

void PrintArr(double[] Arr)
{
    string res = string.Join(";", Arr);
    Console.WriteLine($"Получен следующий скопированный массив: [{res}]");
}


PrintArr(CopyArr(EnterNumbers("Введите массив через точку с запятой: ")));