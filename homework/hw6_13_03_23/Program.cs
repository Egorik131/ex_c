// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Решение:
// int[] CreateArray(int size)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"Input {i+1} array element: ");
//         newArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write($"{array[array.Length - 1]}");
// }

// int CountPositiveNum(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count++;
//     }
//     return count;
// }

// Console.Write("Input M: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateArray(size);
// ShowArray(myArray);
// Console.WriteLine($" -> {CountPositiveNum(myArray)}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// void SysUr (double b1, double k1, double b2, double k2)
// {
//     double y = 0;
//     double x = 0;
//     x = (b1 - b2) / (k2 - k1);
//     y = k2 * (b1 - b2) / (k2 - k1) + b2;
//     Console.WriteLine($"(x: {x}; y: {y})");
// }

// Console.Write("Input b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// SysUr (b1, k1, b2, k2);





