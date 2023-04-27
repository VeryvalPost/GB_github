// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Введите количество столбцов.");
int m = Console.Read();
Console.WriteLine("Введите количество колонок.");
int n = Console.Read();

static double[,] Task_47(int m, int n)
{


    double[,] arr = new double[m, n];
    Random random = new Random();

    // Заполнение массива
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = random.NextDouble();
        }
    }

    return arr;
}

Console.WriteLine(Task_47(m, n));


//Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает его индексы первого найденого числа или же указание, что такого элемента нет.
static void Task_50()
{
    Console.WriteLine("Введите количество столбцов.");
    int m = Console.Read();
    Console.WriteLine("Введите количество колонок.");
    int n = Console.Read();

    Console.WriteLine("Введите проверяемый элемент.");
    double element = Console.Read();


    double[,] arr = Task_47(m, n);

    // поиск элемента в массиве
    bool found = false;
    int rowIndex = -1;
    int colIndex = -1;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (arr[i, j] == element)
            {
                found = true;
                rowIndex = i;
                colIndex = j;
                break;
            }
        }
        if (found)
        {
            break;
        }
    }

    // Вывод результата
    if (found)
    {
        Console.WriteLine($"Элемент {element} найден в столбце {rowIndex}, строчке {colIndex}.");
    }
    else
    {
        Console.WriteLine($"Элемент {element} не найден.");
    }
}
Task_50();

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
static void Task_52()
{
    Console.WriteLine("Введите количество столбцов.");
    int m = Console.Read();
    Console.WriteLine("Введите количество колонок.");
    int n = Console.Read();

    double[,] arr = Task_47(m, n);

    // Подсчет значений 
    for (int j = 0; j < n; j++)
    {
        double sum = 0;
        for (int i = 0; i < m; i++)
        {
            sum += arr[i, j];
        }
        double mean = (double)sum / m;
        Console.WriteLine($"Сумма значений строки {j} - {mean}.");
    }
}
Task_52();