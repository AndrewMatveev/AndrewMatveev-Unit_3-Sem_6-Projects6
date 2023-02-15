// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

double[] EnterNumber(string txt)
{
    System.Console.Write(txt);
    double[] arr = Console.ReadLine().Split(";").Select(double.Parse).ToArray();
    return arr;
}

void PosCount(double[] arr, out int count)
{
    count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }
}

double[] array = EnterNumber("Введите любую последовательность чисел: ");
System.Console.WriteLine($"Введенный массив: [ {string.Join(" ; ", array)} ]");
PosCount(array, out int count);
System.Console.WriteLine($"Количество положительных значений равно {count}");