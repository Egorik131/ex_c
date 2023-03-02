//Задание1.  Напишите программу, которая принимает на вход координаты точки (X и Y),
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int FindQ(int x, int y)
// {
//     if (x > 0 && y > 0)
//         return 1;
//     if (x < 0 && y > 0)
//         return 2;
//     if (x < 0 && y < 0)
//         return 3;
//     if (x > 0 && y < 0)
//         return 4;
//     return 0;
// }
// Console.WriteLine("Input X:");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input Y:");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Point located at {FindQ(x, y)} quard");


//Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

// double FindLine(double z1, double q1, double z2, double q2)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(z2-z1,2)+Math.Pow(q2-q1,2)),2);
// }
// Console.WriteLine("Input X1:");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input Y1:");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input X2:");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input Y2:");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Distance between A and B is {FindLine(x1, y1, x2, y2)}");


//Задача 2.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// string FindQ(int q)
// {
//     if (q == 1)
//         return "y+, x+";
//     if (q == 2)
//         return "y+, x-";
//     if (q == 3)
//         return "y-, x-";
//     if (q == 4)
//         return "y-, x+";
//     return "Не является четвертью";
// }
// Console.WriteLine("Input Q:");
// int q = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(FindQ(q));

//Задача 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N

// void FindQ(int n)
// {
//     int i = 0;
//     int res = 0;
//     while (i < n)
//     {
//         i++;
//         res = i*i;
//         //i++;
//         Console.WriteLine($"{i} -> {res}");
//     }
// }
// Console.WriteLine("Input N:");
// int n = Convert.ToInt32(Console.ReadLine());
// FindQ(n);