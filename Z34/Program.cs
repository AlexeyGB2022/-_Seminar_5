Console.WriteLine("Введите размер массива");
int N;
while (!int.TryParse(Console.ReadLine()!, out N) || N<=0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine ("Неверный ввод");
    Console.ResetColor(); 
    Console.WriteLine("Введите размер массива");   
}

int[] array = new int[N];

void FillArray(int[] arr)
{
    int length = arr.Length;
    int index = 0;
    Random random = new Random();
    while (index < length)
    {
        arr[index] = random.Next(100, 1000);
        index++;
    }

}

void PrintArrayAndEvenNumbers(int[] arr)
{
    Console.WriteLine();
    Console.WriteLine("Массив");
    for (int i = 0; i < N; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();

    int evenNumbers = 0;
    for (int i = 0; i < N; i++)
    {
        if (arr[i]%2 == 0) evenNumbers++;
    }
    Console.WriteLine();
    Console.WriteLine("Количество четных чисел: " + evenNumbers);
}

FillArray(array);
PrintArrayAndEvenNumbers(array);

