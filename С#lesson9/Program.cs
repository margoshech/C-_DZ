// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// string PrintNum(int num)
// {
//     if (num == 1) return "1";  // тумблер выключения
//                               //return num + PrintNum(num-1);   // и суммирование и уменьшение счетчика на 1

//     return PrintNum(num - 1) + "," + num;
// }

// Console.Clear();
// System.Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Натуральные числа в промежутке от 1 до {num}: ");
// System.Console.WriteLine(PrintNum(num));



// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// string PrintNum(int num)
// {
//     if (num == 1)
//     {
//         return "1";
//     }

//     return num.ToString() + "," + PrintNum(num - 1);
// }

// Console.Clear();
// System.Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Натуральные числа в промежутке от {num} до 1: ");
// System.Console.WriteLine(PrintNum(num));





// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int Summa(int current, int finish)
// {
//     int result = current;
//     if (current < finish)
//     {
//         result += Summa(current + 1, finish);
//     }
//     return result;
// }


// Console.Clear();
// System.Console.WriteLine("Введите целое число M");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите целое число N");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Сумма от {m} до {n}: ");
// System.Console.WriteLine(Summa(m, n));








// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int akkerman(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) return akkerman(m - 1, 1);
//     else return akkerman(m - 1, akkerman(m, n - 1));
// }

// Console.Write($"Функция Аккермана равно {akkerman(m, n)} ");