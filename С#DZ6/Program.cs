// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double GetRandomNumber(double minimum, double maximum)
{ 
    Random random = new Random();
    return random.NextDouble() * (maximum - minimum) + minimum;
}

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble(), 2);
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
        {
        for (int j=0; j<array.GetLength(1);j++)
            System.Console.Write($"{array[i,j],3}    ");
        System.Console.WriteLine();
        }
}

Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] array = new double [rows, cols];
FillArray(array);
PrintArray(array);


// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// void FillArray(int[,] array)
// {
//     for (int i=0; i  < array.GetLength(0); i++)
//     {
//         for (int j=0; j<array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-30, 30);
//         }
//     }

// }

// void PrintArray(int[,] array)
// {
//     for (int i=0; i<array.GetLength(0); i++)
//     {
//         for (int j=0; j < array.GetLength(1);j++)
//         {
//             System.Console.Write($"{array[i,j],3}    ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void NumRet(int[,] array, int num) 
// {
//     for (int i = 0; i < array.GetLength(0); i++) 
//     {
//         for (int j = 0; j < array.GetLength(1); j++) 
//         {
//             if(array[i, j] == num)
//             {
//                 System.Console.WriteLine ($"Позиция значения {num}: {i},{j}");

//                 return;
//             }
//         } 
//     }

//     System.Console.WriteLine ($"{num} такого числа в массиве нет");
// } 

// Console.Clear();
// Console.WriteLine("Введите искомое число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int [rows, cols];
// FillArray(array);
// PrintArray(array);
// NumRet(array, num);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// void FillArray(int[,] array)
// {
//     for (int i=0; i  < array.GetLength(0); i++)
//     {
//         for (int j=0; j<array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-30, 30);
//         }
//     }

// }

// void PrintArray(int[,] array)
// {
//     for (int i=0; i<array.GetLength(0); i++)
//     {
//         for (int j=0; j < array.GetLength(1);j++)
//         {
//             System.Console.Write($"{array[i,j],3}    ");
//         }
//         System.Console.WriteLine();
//     }
// }
 
// void Summ(int [,] array) 
// {
//     int sum = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum += array[i, j];
//         }
//         System.Console.WriteLine($"Ср ар {sum / array.GetLength(0)}");
//     }
// }

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int [rows, cols];
// FillArray(array);
// PrintArray(array);
// Summ(array);
