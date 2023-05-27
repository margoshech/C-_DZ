// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 999);
//     }
// }

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//     {
//         Console.Write($"{item} ");
//     }
//     System.Console.WriteLine();
// }

// int SearchCount(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]  % 2 == 0)
//         {
//             count += 1;
//         }
//     }
//     return count;
// }


// int[] array = new int[4];
// FillArray(array);
// System.Console.WriteLine("Сгенерировался такой массив");
// PrintArray(array);
// System.Console.WriteLine($"Найдено {SearchCount(array)} четных чисел");


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 100);
//     }
// }

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//     {
//         Console.Write($"{item} ");
//     }
//     System.Console.WriteLine();
// }

// int Summa(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0)
//         {
//             sum += array[i];
//         }
//     }
//     return sum;
// }


// int[] array = new int[4];
// FillArray(array);
// System.Console.WriteLine("Сгенерировался такой массив");
// PrintArray(array);
// System.Console.WriteLine($"Сумма нечетных чисел в массиве - {Summa(array)}");



// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// void FillArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 100);
//     }
// }

// void PrintArray(double[] array)
// {
//     foreach (double item in array)
//     {
//         Console.Write($"{item} ");
//     }
//     System.Console.WriteLine();
// }

// double Summa(double[] array)
// {
//     double sum = 0;
//     double max = 0;
//     double min = 0;
//     for (int i = 0; i < array.Length; i++)
//     {  

//         if (array[i] > max)
//         {
//             max = array[i];
//         }
        
//         if (array[i] < min)
//         {
//             min = array[i];
//         }
//     }

//     sum = max + min;
//     return sum;
// }


// double[] array = new double[4];
// FillArray(array);
// System.Console.WriteLine("Сгенерировался такой массив");
// PrintArray(array);
// System.Console.WriteLine($"Сумма нечетных чисел в массиве: {Summa(array)}");

