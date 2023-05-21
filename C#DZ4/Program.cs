// 1
// int summa(int num)
// {
//     int res=0;
//     for (int i=1; i<=num; i++) {
//     res = res + i;
//     }
//     return res;
// }

// try
// {
// System.Console.WriteLine("Введите натуральное число");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Сумма всех чисел от 1 до {num} равна {summa(num)}");
// }
// catch
// {
//     System.Console.WriteLine("Надо вводить именно целое число!!!");
// }


//2
// int Result(int x)
// {
//     int count = 0;
//     while (x > 0)
//     {
//         x = x / 10;
//         count++;
//     }
//     return count;
// }

// System.Console.WriteLine("Введите любое число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Колличество цифр в числе: {Result(num)}");



//3

// int Resault(int num)
// {
//     int result = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         result *= i;
//     }
//     return result;
// }

// System.Console.WriteLine("Введите любое число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Факториал числа: {Resault(num)}");


// 4
// int[] CreateArray(int n)
// {
//     Random random = new Random();
//     int[] numbers = new int[n];
//     System.Console.Write("Массив:");
//     for (int x = 0; x < numbers.Length; x++)
//     {
//         numbers[x] = random.Next(0, 2);
//     }
//     return numbers;
// }


// void PrintArray(int [] numbers)
// {
//     for (int x = 0; x < numbers.Length; x++)
//     System.Console.Write($" {numbers[x]}");
//     Console.WriteLine();
// }

// double Result(int [] numbers)
// {
//     double summ = 0;
//     for (int x = 0; x < numbers.Length; x++)
//     {
//         summ += numbers[x];
//     }
//     return summ / numbers.Length;
// } 

// int [] numbers = CreateArray(8);
// PrintArray(numbers);
// Console.WriteLine($"Среднне врифмитическое массива: {Result(numbers)}");






// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//  int Resault(int a, int b)
// {
//     int res = 1;

//     for (int i =1; i<=b; i++)
//     {
//         res*=a;
//     }
//     return res;
// }

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите степень");
// int num2 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"число {num} в степени {num2} {Resault(num, num2)}");





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


// int result (int num)
// {
//     int res = 0;
//     while (num>0)
//     {
//         res += num%10;
//         num /= 10;
//     }
//     return res;
// }

// System.Console.WriteLine("Введите чило");
// int num = System.Convert.ToInt32(System.Console.ReadLine());
// int res = result(num);
// System.Console.WriteLine($"сумма цифр числа {num} - {res}");


// Задача 26 HARD Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4

// int result (double num)
// {
//     int count = 0;
//     int intNum= System.Convert.ToInt32 (num);
//     while (intNum>0)
//     {
//         count++;
//         intNum /= 10;
//     }

//     int count2 = 0;
//     while (num * Math.Pow(10, 1 + count2) % 10 != 0)
//     {
//          count2++;
//     }
//     return count + count2;
// }
// System.Console.WriteLine("Введите число");
// double num = Convert.ToDouble (System.Console.ReadLine ());
// int count = (result(num));
// System.Console.WriteLine($"колличество цифр в числе {num} - {count}");

