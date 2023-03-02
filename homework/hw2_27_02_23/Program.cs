// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Решение:
// int SecondNum(int num)
// {
//     while (num < 100 || num > 999) 
//     {    
//         Console.Write("Wrong number, please re-enter three-digit number:");
//         num = Convert.ToInt32(Console.ReadLine());
//     }
//     return num % 100 / 10;
// }   
// Console.Write("Enter three-digit number:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SecondNum(num));


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Решение:
// int ThirdNum(int num)
// {
//     while (num > 999)
//     {
//         num = num / 10;
//     }
//     num = num % 10;
//     return num;
// }
// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 100) Console.WriteLine("Третьей цифры нет");
// else Console.WriteLine(ThirdNum(num));


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Решение:
// void Weekend(int num)
// {
//     while (num < 1 || num > 7) 
//     {    
//         Console.Write("Wrong number day of the week, please re-enter:");
//         num = Convert.ToInt32(Console.ReadLine());
//     }
//     if (num == 6 || num == 7) Console.WriteLine("Да");
//     else Console.WriteLine("Нет");
// }

// Console.Write("Input number day of the week: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Weekend(num);