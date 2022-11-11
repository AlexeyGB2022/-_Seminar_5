Console.WriteLine("Введите размер массива");
int N;
while (!int.TryParse(Console.ReadLine()!, out N) || N<=0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine ("Неверный ввод");
    Console.ResetColor(); 
    Console.WriteLine("Введите размер массива");   
}

int i = 0;
float[] arr = new float[N];

while (i<N)
{
    Console.WriteLine ($"Введите {i+1} элемент массива");

    while (!float.TryParse(Console.ReadLine()!, out arr[i]))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine ("Неверный ввод");
        Console.ResetColor(); 
        Console.WriteLine($"Введите {i+1} элемент массива");   
    }

    i++;
}

void PrintArray(float[] arr)
{
    Console.WriteLine ("Массив");
    for (int i = 0; i < N; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
    Console.WriteLine();
}

void Difference(float[] arr)
{
    float max = arr[0];
    float min = arr[0];
    for (int i = 0; i < N; i++)
    {
        if (arr[i]>max) max = arr[i];
        if (arr[i]<min) min = arr[i];
    }
    Console.WriteLine();
    if (min<0)
    Console.WriteLine ($"Разница максимального и минимального элемента массива: {max} - ({min}) = " + (max-min));
    else
    Console.WriteLine ($"Разница максимального и минимального элемента массива: {max} - {min} = " + (max-min));
}

Console.WriteLine();
PrintArray(arr);
Difference(arr);