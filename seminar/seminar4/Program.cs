





//Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

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
//         Console.Write (array[i] + "");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// ShowArray(CreateRandomArray(size, minValue, maxValue));



//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

// int Q (int num)
// {
//     int i = 1;
//     while (num > 10)
//     {  
//       num = num / 10;
//       i++;
//     }
//     return i;
// }
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine (Q(num));


//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4  -> 24
//5  -> 120

// int factorial(int n)
// {
//     int i = 1;
//     int res = 1;
//     for (i = 1; i <= n; i++)
//     {
//         res = res * i;
//     }
//     return res;
// }
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(factorial(n));
