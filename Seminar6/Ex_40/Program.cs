// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

double[] EnterNumbers(string txt)
{
    System.Console.Write(txt);
    return Console.ReadLine()!.Split(";").Select(double.Parse).ToArray();
}

void PrintArr(double[] Arr)
{
    string res = string.Join(";", Arr);
    Console.WriteLine($"Получены следующие длины сторон треугольника: [{res}]");
}

void TriangleCheck(double[] arr)
{
    if ((arr[0] + arr[1]) > arr[2] && (arr[1] + arr[2]) > arr[0] && (arr[2] + arr[0]) > arr[1])
    {
        System.Console.WriteLine($"Треугольник со стронами {arr[0]}, {arr[1]}, {arr[2]} существует");
    }
    else System.Console.WriteLine($"Треугольник со стронами {arr[0]}, {arr[1]}, {arr[2]} не существует");
}

double[] array = EnterNumbers("Введите длины сторон треугольника: ");
PrintArr(array);
TriangleCheck(array);