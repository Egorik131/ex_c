// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Решение:
// Console.Write("Input first number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int max = a, min = b;
// if (b > a)
// {
//     max = b;
//     min = a;
// }   
// Console.WriteLine($"max number = {max}, min number = {min}");


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Решение:
// Console.Write("Input first number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input third number: ");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// Console.WriteLine($"max number = {max}");


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Решение:
// Console.Write("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// string ans = "да";
// if (a % 2 != 0) ans = "нет";
// Console.WriteLine(ans);


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Решение:
// Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int current = 1;
// if (n == 1)
//     Console.WriteLine("No even numbers.");
// else
// {
//     while (current <= n)
//     {
//         if (current % 2 == 0)
//             Console.Write($"{current} ");
//     current++;
//     }
// }