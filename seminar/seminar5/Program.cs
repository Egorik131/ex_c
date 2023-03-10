// Задача 1. Задайте массив из 12 элементов, заполненными случайными числами из промежутка (-9. 9)
// Найдите сумму отрицательных и положительных элементов массива

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
//         Console.Write (array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void FindSum (int[] array)
// {
//     int sumPos = 0;
//     int sumNeg = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 0) sumPos += array[i];
//         else sumNeg += array[i];
//     }
//     Console.WriteLine($"Sum of positive digits is -> {sumPos}, Sum of negative digits is -> {sumNeg}");
// }
// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray (size, minValue, maxValue);
// ShowArray(myArray);
// FindSum(myArray);

// Задача 2. Напишите программу замена элементов массива: положительные жлементы замените на соотвествующие отрицательные и наоборот
// [-4, -8, 8, 2] -> [4, 8 , -8, -2]


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
//         Console.Write (array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] ChangeElementOfArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= (-1);
//     }
//     return array;
// }

// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray (size, minValue, maxValue);
// ShowArray(myArray);
// myArray = ChangeElementOfArray(myArray);
// ShowArray(myArray);



// Задача 3. Задайте массив и определите находится ли заданное число в массиве

// Вариант ввода массива не по рандому

// int[] CreateArray(int size)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine($"Введите {i+1} элемент массива ")
//         newArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return newArray;
// }

// Вариант по рандому

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
//         Console.Write (array[i] + " ");
//     }
//     Console.WriteLine();
// }
// // 1 вариант
// bool FindXXX (int[] array, int xxx)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == xxx) return true;
//     }
//     return false;
// }
// // 2 вариант
// // string FindXXX (int[] array, int xxx)
// // {
// //     string ans = "NO";
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         if (array[i] == xxx) ans = "Yes";
// //     }
// //     return ans;
// // }

// Console.WriteLine ("Input N:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray (size, minValue, maxValue);
// ShowArray(myArray);
// Console.WriteLine(FindXXX(myArray, n));


// Задача 4. Задайте одномерный массив из 123 случайных чисел. Найти количесвто элементов значения которых лежат в отдезке от 10 до 99. 
// По желанию можно сделать с запросом на любой интервал.

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
//         Console.Write (array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int QDigitsInInterval (int[] array, int start, int stop)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= start && array[i] <= stop) count++;
//     }
//     return count;
// }

// Console.Write ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Input begin of interval:");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Input end of interval:");
// int stop = Convert.ToInt32(Console.ReadLine());


// int[] myArray = CreateRandomArray (size, minValue, maxValue);
// ShowArray(myArray);
// Console.WriteLine(QDigitsInInterval(myArray, start, stop));