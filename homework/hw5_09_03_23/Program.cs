//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Решение:
// int[] CreateArray(int size)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"Input {i+1} three-digit array's element: ");
//         newArray[i] = Convert.ToInt32(Console.ReadLine());
//         if (newArray[i]< 100 || newArray[i] > 999)
//         {
//             Console.WriteLine($"Element is not three-digit!");
//             Console.Write($"Input {i+1} three-digit array's element: ");
//             newArray[i] = Convert.ToInt32(Console.ReadLine());
//         }
//     }
//     return newArray;
// }
// void ShowArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write($"{array[array.Length - 1]}]");
// }

// int QEvenNumbers (int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) count++;
//     }
//     return count;
// }

// Console.Write ("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateArray (size);
// ShowArray(myArray);
// Console.WriteLine($" -> {QEvenNumbers(myArray)}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write($"{array[array.Length - 1]}]");
// }

// int SumNumEvenPositions(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0) sum += array[i];
//     }
//     return sum;
// }

// Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateArray(size);
// ShowArray(myArray);
// Console.WriteLine($" -> {SumNumEvenPositions(myArray)}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//Решение:
// double[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     double[] newArray = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
//     }
//     return newArray;
// }

// void ShowArray(double[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write("{0:0.00}", array[i]);
//         if (i < array.Length - 1) Console.Write(" ");
//     }
//     Console.Write("]");
// }

// void DiffMaxMin(double[] array)
// {
//     double diff = 0;
//     double min = array[0];
//     double max = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] <= min) min = array[i];
//             if (array[i] >= max) max = array[i];
//     }
//     Console.WriteLine("{0:0.00}", diff = max - min);
// }

// Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// double[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// Console.Write(" -> ");
// DiffMaxMin(myArray);