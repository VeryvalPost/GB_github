using System;

static void Task_34()
{
    // Рандомный массив
    int[] numbers = new int[10];
    Random rand = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rand.Next(100, 1000);
    }

    // Счиатем элементы
    int evenCount = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            evenCount++;
        }
    }

    Console.WriteLine("Получили массив:");
    Console.WriteLine(string.Join(", ", numbers));
    Console.WriteLine($"Количеств четных чисел -  {evenCount} .");
}

Task_34();



static void Task_36()
{
    // Рандомный массив
    int[] numbers = new int[10];
    Random rand = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rand.Next(1, 101);
    }

    // Счиатем элементы
    int oddSum = 0;
    for (int i = 1; i < numbers.Length; i += 2)
    {
        oddSum += numbers[i];
    }

    Console.WriteLine("Получили массив:");
    Console.WriteLine(string.Join(", ", numbers));
    Console.WriteLine($"Сумма элементов нечетных позиций {oddSum}.");
}

Task_36();



static void Task_38()
{
    // Определим массив
    double[] numbers = { 3, 7, 22, 2, 78 };

    // Ищем разницу
    double max = numbers[0];
    double min = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    double diff = max - min;

    Console.WriteLine("Массив:");
    Console.WriteLine(string.Join(", ", numbers));
    Console.WriteLine($"Разница составит {diff}.");
}
Task_38();





