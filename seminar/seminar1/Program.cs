// Console.WriteLine("Input number");
// int a = Convert.ToInt32(Console.ReadLine());
// //Console.WriteLine($" Quad of {a} -> {a * a}"); //" You input this number -> " + a 
// int Quad = a * a;
// Console.WriteLine(Quad);

//Задача 2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num2 * num2 == num1)
// {
//     Console.WriteLine($"First number {num1} is quad if second number {num2}");
// }
// else
// {
//     Console.WriteLine($"First number {num1} is not quad if second number {num2}"); 
//}

// Задача 3. Напишите программу, которая на вход принимат одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// Console.WriteLine("Input N");
// int n = Convert.ToInt32(Console.ReadLine());
// int current = n * (-1);
// while(current <= n)
// {
//     Console.Write(current + " ");
//     current++;
// }

// Задача 4. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа.
    // 456 -> 6   
    // 782 -> 2
    // 918 -> 8 

// Console.WriteLine("Input three digit number");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 99 && num <= 999) 
// {
//     int remainder = num % 10;
//     Console.WriteLine($"Last digit of {num} -> {remainder}");
// }
// else
// {
//     Console.WriteLine("You input not three digit number");
// }