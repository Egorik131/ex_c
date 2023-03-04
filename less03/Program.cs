// Виды методов

// Метод 1 "не принимает никаких аргументов и ничего не возвращает"
// void Method1()
// {
//     Console.WriteLine("Hi");
// }
// Method1();


// Метод 2 "принимает какие-то аргументы, но ничего не возвращают"
// void Method2(string text, int num)
// {
//     int i = 1;
//     while (i < num)
//     {
//         Console.WriteLine(text);
//         i++;
//     }
// }
// //Method2("text 123");
// // Можно указывать непосредственно агрумент к котороve обращаемся когда много аргументов в методе
// // (именнованные аргументы. Не обязательно делать по поярдкаку) Method2(i: 2, text: "text 123"); 
// Method2(num: 2, text: "text 123"); 


// Метод 3 "может что-то возвращать, но не принимает никаких
//          аргументов. Например, может служить для генерации случайных данных."
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// Метод 4 "что-то принимает (аргументы, данные). И что-то возвращает для дальнейшей работы"
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "asdf");
// Console.WriteLine(res);

// Цикл for
// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

// Таблица умножения
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// Задача. Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
// заменить большими «К», а большие «С» заменить на маленькие «с».

// string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского корроля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty
//             012
// s[3] = r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result += $"{newValue}";
//         else result += $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text, ' ' , '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'к' , 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'с' , 'С');
// Console.WriteLine(newText);

// Задача сортировки массива - упорядочить в обтратном порядке
// Решение
// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]}");
//     }
//     Console.WriteLine();
// }
// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition])
//             {
//                 minPosition = j;
//             }
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }
// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);
