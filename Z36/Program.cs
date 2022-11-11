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
        arr[index] = random.Next(-100, 101);
        index++;
    }

}

void PrintArrayAndSum(int[] arr)
{
    Console.WriteLine();
    Console.WriteLine("Массив");
    for (int i = 0; i < N; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();

    int sum = 0;
    for (int i = 1; i < N; i=i+2)
    {
       sum = sum + arr[i];
    }
    Console.WriteLine();
    Console.WriteLine("Сумма элементов с нечетными индексами: " + sum);
}

FillArray(array);
PrintArrayAndSum(array);
