// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Решение:
// void Palindrome (int num)
// {
//     while (num < 10000 || num > 99999)
//     {
//         Console.Write("Wrong number, please re-enter five-digit number: ");
//         num = Convert.ToInt32(Console.ReadLine());
//     }
//     int i = 1;
//     int del = 10000;
//     int a = 0;
//     int b = 0;
//     string ansv = "да";
//     while (i <= 2)
//         {
//             a = num / del;
//             b = num % 10;
//             num = num % del / 10;
//             i++;
//             del /= 100;
//             if (a != b)
//             {
//                 ansv = "нет";
//                 break; 
//             }
//         }
//     Console.WriteLine(ansv);
// }
// Console.Write("Input five-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Palindrome(num);


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Решение:
// double FindLine(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
// }
// Console.WriteLine("Input point A coordinates:");
// Console.Write("X1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Z1: ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input point B coordinates:");
// Console.Write("X2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Z2: ");
// double z2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Distance between A and B is {FindLine(x1, y1, z1, x2, y2, z2)}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Решение:
// void FindDegre(int n)
// {
//     int i = 0;
//     int degre = 3;
//     double res = 0;
//     while (i < n)
//     {
//         i++;
//         res = Math.Pow(i, degre);
//         Console.WriteLine($"{i} -> {i}^{degre} -> {res}");
//     }
// }
// Console.WriteLine("Input N:");
// int n = Convert.ToInt32(Console.ReadLine());
// FindDegre(n);