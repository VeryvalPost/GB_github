using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите исходный массив строк, разделенных пробелами:");
        string[] inputArray = Console.ReadLine().Split();

        string[] outputArray = FilterStrings(inputArray);

        Console.WriteLine("Новый массив строк с длиной не более 3 символов:");
        
        foreach (string str in outputArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterStrings(string[] inputArray)
    {
        int count = 0;

        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] outputArray = new string[count];
        int index = 0;

        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                outputArray[index] = str;
                index++;
            }
        }

        return outputArray;
    }
}