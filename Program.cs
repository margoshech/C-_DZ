// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Введите первое число");
//  int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
//  int num2 = Convert.ToInt32(Console.ReadLine());
// if (num > num2) 
// {
//      Console.WriteLine($"max  = {num}");
// }
//  else if (num2 > num) {
//      Console.WriteLine($"max = {num2}");
//  }
//  if (num < num2) 
// {
//      Console.WriteLine($"min  = {num}");
// }
//  else if (num2 < num) {
//      Console.WriteLine($"min = {num2}");
//  }



//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите первое число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int num3 = Convert.ToInt32(Console.ReadLine());
// if (num > num2 && num > num3) 
// {
//       Console.WriteLine($"max  = {num}");
// }
// else if (num2 > num && num2 > num3) {
//       Console.WriteLine($"max = {num2}");
// }
// else if (num3 > num && num3 > num2) {
//       Console.WriteLine($"max = {num3}");
// }




// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 == 0)
// {
//          Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int start = 1;
// for (int i = start; i <= num; i++) 
// {
//     if (i % 2 == 0) 
//     {
//         Console.WriteLine(i);
//     }
// }



// Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 10)
// {
//     Console.WriteLine("нет");
//     System.Environment.Exit(1);
// }
// if (num > 99)
// {
//     while (num > 99)
//     {
//         num = num / 10;
//     }
// }
// Console.WriteLine(num % 10);
