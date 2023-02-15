// 1:47 - time
// 
// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int EnterN(string txt)
{
    System.Console.Write(txt);
    return Convert.ToInt32(Console.ReadLine());
}


void Fibonacchi(int N)
{
    int[] arr = new int[N];
    arr[0] = 0;
    arr[1] = 1;

    for (int i = 2; i < N; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    System.Console.Write(string.Join(", ", arr));
}

int N = EnterN("Введите кол-во выводимых чисел из последовательности Фибоначчи: ");
Fibonacchi(N);