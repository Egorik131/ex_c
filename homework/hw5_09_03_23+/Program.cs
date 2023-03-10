//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Решение задачи 34 с автоматическим заполнением массива:
// int[] CreateRandomArray(int size)
// {
//     int minValue = 100;
//     int maxValue = 999;
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write (array[i] + " ");
//     }
//     Console.WriteLine();
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

// int[] myArray = CreateRandomArray (size);
// ShowArray(myArray);
// Console.WriteLine(QEvenNumbers(myArray));



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Решение задачи №36 с автоматическим заполеннием массива:
// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
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

// Console.Write("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// Console.WriteLine(SumNumEvenPositions(myArray));



