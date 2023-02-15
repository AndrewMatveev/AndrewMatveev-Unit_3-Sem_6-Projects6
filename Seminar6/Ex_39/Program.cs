








int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    Random rand = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(minValue, maxValue + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

void ReverseArray(int[] arr)
{
    int temp; 
    for(int i = 0; i < arr.Length/2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

var array = GenerateArray(5, 0, 10);
PrintArray(array);
ReverseArray(array);
PrintArray(array);