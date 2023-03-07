// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Решение:
// void Stepen(int a, int b)
// {
//     int step = a;
//     for (int i = 2; i <= b; i++)
//     {
//         step *= a;
//         Console.WriteLine(step);
//     }
//     Console.WriteLine($"A = {a}, B = {b}  ->  {a}^{b} = {step}");
// }
// Console.Write("Input A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Stepen(a, b);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Решение:
// int QuantNum (int n)
// {
//     int res = 1;
//     int count = n;
//     for (res = 1; count >= 10; res++)
//     {
//         count = count / 10;
//     }
//     return res;
// }
// void SumNumbers(int n)
// {
//     int sum = 0;
//     int current = n;
//     for (int i = 1; i <= QuantNum(n); i++)
//     {
//         sum += current % 10; 
//         current = current / 10;
//     }
//     Console.Write($"Sum of number: {sum}");
// }
// Console.Write("Input number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// SumNumbers(n);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Решение:

//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 }; // массив дан сразу, второй вариант, когда массив по рандому

// int[] CreateRandomArray(int size, int minValue, int maxValue) // размер массива, от минимального до максиального значения
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void ArrayView(int[] array)
// {
//     int count = array.Length;
//     Console.Write("[");
//     for (int i = 0; i < count - 1; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write($"{array[count-1]}]");
// }
// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// ArrayView(CreateRandomArray(size,minValue,maxValue));