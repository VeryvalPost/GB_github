//   Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//   
//   3, 5 -> 243 (3⁵)
//   
//   2, 4 -> 16
//   


int Task_One (int number, int power) {
    int degree = 1;
    for (int i=0; i<power; i++) {
        degree = degree * number; 
    } 
    return degree;
    }   
Console.Write("\n");
Console.Write("Задача №25\n");
Console.Write(Task_One (3,5) + "\n");
Console.Write(Task_One (2,4) + "\n");




//   Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//   
//   452 -> 11
//   
//   82 -> 10
//   
//   9012 -> 12
//   



int Task_Two (int number) {
    int sum = 0;
    char[] char_number =  number.ToString().ToCharArray();
    
    foreach (char entity in char_number) {
        sum = sum + (int)Char.GetNumericValue(entity);
        
    }
    return sum;
}


Console.Write("\n");
Console.Write("Задача №25\n");
Console.Write(Task_Two (452) + "\n");
Console.Write(Task_Two (82) + "\n");
Console.Write(Task_Two (9012) + "\n");


//   Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//   
//   1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//   
//   6, 1, 33 -> [6, 1, 33]


void Task_Three() {
    Random rnd = new Random(); 
    int[] arr = new int[8];
    for (int i=0; i< arr.Length; i++){
       arr[i] = (int)(rnd.Next(0,99));
    }
    foreach (int element in arr){
        Console.Write(element.ToString() + " ");
    }
    
  Console.Write(" \n");
}
Console.Write("\n");
Console.Write("Задача №29\n");
Task_Three();
Task_Three();