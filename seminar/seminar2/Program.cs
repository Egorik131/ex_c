// 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
// Решение:
// int BiggestDigit(int num)
// {
//     int ed = num % 10;
//     int dec = num / 10;

//     if (dec > ed) return dec;
//     else return ed;
// }

// int randomnum = new Random().Next(10, 100);
// int res = BiggestDigit(randomnum);
// Console.WriteLine($"Biggest of of {randomnum} -> {res}");


// 2. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int DelDigit(int num)
// {
//     int sot = num / 100;
//     int ed = num % 10;
//     int res = sot * 10 + ed;

//     return sot * 10 + ed;
// }

// int randomnum = new Random().Next(100, 1000);
// Console.WriteLine(randomnum);
// Console.WriteLine(DelDigit(randomnum));

//3. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14  ->  нет
//46  ->  нет
//161 ->  да

// bool KratNum(int num)
// {
//     return num % 7 == 0 && num % 23 == 0;
// }

// int randomnum = new Random().Next(1, 1000);
// randomnum = 161;
// Console.WriteLine(randomnum);
// Console.WriteLine(KratNum(randomnum));


//4. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// bool Quad(int num1, int num2)
// {
//     return num1 * num1 == num2 | num2 * num2 == num1;
// }

// int randomnum1 = new Random().Next(1, 1000);
// int randomnum2 = new Random().Next(1, 1000);

// randomnum1 = 5;
// randomnum2 = 25;
// Console.WriteLine(randomnum1);
// Console.WriteLine(randomnum2);
// Console.WriteLine(Quad(randomnum1, randomnum2));

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
//Если второе число не кратно числу первому, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно


int Krat(int num1, int num2)
{
    int res = num1 % num2;
    return res;
}   
   
int randomnum1 = new Random().Next(1, 1000);
int randomnum2 = new Random().Next(1, 1000);

//randomnum1 = 16;
//randomnum2 = 4;
//Console.WriteLine(randomnum1);
//Console.WriteLine(randomnum2);
//Console.WriteLine(Krat(randomnum1, randomnum2));

if (Krat(randomnum1, randomnum2) == 0) Console.WriteLine($"Кратно");
else Console.WriteLine($"не кратно, {Krat(randomnum1, randomnum2)}");