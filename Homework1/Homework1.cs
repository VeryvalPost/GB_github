//        Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//        
//        a = 5; b = 7 -> max = 7
//        a = 2 b = 10 -> max = 10
//        a = -9 b = -3 -> max = -3
//        

void Task_One (int first, int second) {

    Console.Write ($"Введены числа: {first} и {second}\n");
    if (first > second) Console.Write ($"Число {first} больше {second}\n");
    else Console.Write ($"Число {second} больше {first}\n");
    Console.Write ("");
}
Console.Write ("\n");
Console.Write ("Задача 2\n");
Task_One(5,7);
Task_One(2,10);
Task_One(-9,-3);



//        Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//        
//        2, 3, 7 -> 7
//        44 5 78 -> 78
//        22 3 9 -> 22
//        

void Task_Two (int first, int second, int third) {
    int maximum = first;
    Console.Write ($"Введены числа: {first} , {second} и {third}\n");
    if (maximum < second) maximum = second;
    else if (maximum < third) maximum = third;
    
    Console.Write ($"Максимальное из трех чисел явлется {maximum}\n");
    Console.Write ("");
}
Console.Write ("\n");
Console.Write ("Задача 4\n");
Task_Two(2,3,7);
Task_Two(44,5,78);
Task_Two(22,3,9);


//        Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//        
//        4 -> да
//        -3 -> нет
//        7 -> нет
//      

void Task_Three (int first) {
    
    if (first%2 == 0) 
    Console.Write($"Число {first} - четное\n");
    else Console.Write($"Число {first} - не четное\n");
    

}

Console.Write ("\n");
Console.Write ("Задача 6\n");
Task_Three (4);
Task_Three (-3);
Task_Three (7);

//        Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//        
//        5 -> 2, 4
//        8 -> 2, 4, 6, 8

void Task_Four (int number) {
    int z = 0;
    for (int i=2; i <= number; i+=2) {
    z= z+1;
    Console.Write($" {z} - ");
    Console.Write($" {i}");

    }   

}

Console.Write ("\n");
Console.Write ("Задача 8\n");
Console.Write ("Введите число N\n");
int qty = Console.Read();
Task_Four (qty);
Task_Four (5);
Task_Four (8);
