static void Task41()
    {
        Console.Write("Введите кол-во чисел: ");
        int m = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = 1; i <= m; i++)
        {
            Console.Write($"Введите следующее число {i}: ");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Вы ввели {count} чисел больше 0.");
    }

Task41();


static void Task43()
    {
        Console.Write("Введите k1: ");
        double k1 = double.Parse(Console.ReadLine());
        Console.Write("Введите b1: ");
        double b1 = double.Parse(Console.ReadLine());
        Console.Write("Введите k2: ");
        double k2 = double.Parse(Console.ReadLine());
        Console.Write("Введите b2: ");
        double b2 = double.Parse(Console.ReadLine());

        if (k1 == k2)
        {
            Console.WriteLine("Линии параллельны и не пересекаются.");
        }
        else
        {
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;
            Console.WriteLine($"Точка пересечения ({x}, {y}).");
        }
    }

Task43();