//  Задача 19
//  
//  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//  
//  14212 -> нет
//  
//  12821 -> да
//  
//  23432 -> да

void Task_One (int number) {
    char[] char_number =  number.ToString().ToCharArray();
    if ((char_number[0] == char_number[4])&&(char_number[1] == char_number[3]))
    {
    Console.Write(number.ToString()+ " - Палиндром\n");
    } else Console.Write(number.ToString()+" - Не палиндром\n");
    

    }   
Console.Write("\n");
Console.Write("Задача №19\n");
Task_One (14212);
Task_One (12821);
Task_One (23432);

//  
//  Задача 21
//  
//  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//  
//  A (3,6,8); B (2,1,-7), -> 15.84
//  
//  A (7,-5, 0); B (1,-1,9) -> 11.53
//  




void Task_Two(double xone,double yone,double zone, double xtwo,double ytwo,double ztwo) {
    double lengthOfAB = Math.Sqrt(Math.Pow(xtwo-xone,2) + Math.Pow(ytwo-yone,2) + Math.Pow(ztwo-zone,2));
    Console.Write($"Для координат х1-{xone}, y1-{yone}, z1-{zone} и  х2-{xtwo}, y2-{ytwo}, z2-{ztwo} \n");   
    Console.Write($"Длина отрезка составит -{lengthOfAB} \n");   
    }   
Console.Write("\n");
Console.Write("Задача №21\n");
Task_Two (3,6,8,2,1,-7);
Task_Two (7,-5,0,1,-1,9);


//  Задача 23
//  
//  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//  
//  3 -> 1, 8, 27
//  5 -> 1, 8, 27, 64, 125



void Task_Three(int n) {
    for (int i=1; i<=n; i++){  
    Console.Write($"{Math.Pow(i,3)} ");
    }   
  Console.Write("\n");  
}

Console.Write("\n");
Console.Write("Задача №23\n");
Task_Three (3);
Task_Three (5);