//      Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//      
//      456 -> 5
//      782 -> 8
//      918 -> 1
//   


void Task_One (int number) {
    char[] char_number =  number.ToString().ToCharArray();
    Console.Write(char_number[1] + "\n");

    }   
Console.Write("\n");
Console.Write("Задача №10\n");
Task_One (456);
Task_One (782);
Task_One (918);

//      Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//      
//      645 -> 5
//      
//      78 -> третьей цифры нет
//      
//      32679 -> 6
//      


void Task_Two (int number) {
    char[] char_number =  number.ToString().ToCharArray();

    if (char_number.Length < 3) Console.Write("Третьего числа нет\n");
    else  Console.Write(char_number[2] + "\n");
    }   
Console.Write("\n");
Console.Write("Задача №13\n");
Task_Two (645);
Task_Two (78);
Task_Two (32679);


//      Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//      
//      6 -> да
//      7 -> да
//      1 -> нет

void Task_Three (int day) {
    if ((day > 7)||(day < 1)) Console.Write("Нет такого дня.\n");
    else 
        switch (day) {
            case 6:
                Console.Write("Выходной\n");
                break;
            case 7:
                Console.Write("Выходной\n");
                break;
            default:
                Console.Write("Рабочий :(\n");
                break;
        }
        
    }   
Console.Write("\n");
Console.Write("Задача №15\n");
Console.Write("Введите день недели\n");
int day = Console.Read();
Task_Three(day);
Task_Three (6);
Task_Three (7);
Task_Three (1);