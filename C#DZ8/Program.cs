// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j],3}    ");
//         }

//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void SortLine(int[,] array)
// {
//     int temp;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1 - j; k++)
//             {
//                 if (array[i, k] < array[i, k+1])
//                 {
//                     temp = array[i, k];
//                     array[i, k] = array[i, k+1];
//                     array[i, k+1] = temp;
//                 }
//             }
//         }
//     }
// }

// int[,] array = new int[4,3];
// FillArray(array);
// PrintArray(array);
// SortLine(array);
// PrintArray(array);




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j],3}    ");
//         }

//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[] CaculateSumLines(int[,] array)
// { 
//     int[] sums = new int[array.GetLength(0)];
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sums[i] += array[i, j];
//         }
//     }
//     return sums;
// }

// int[,] array = new int[4,3];
// FillArray(array);
// PrintArray(array);
// int[] sums = CaculateSumLines(array);
// System.Console.WriteLine($"Min sum = {sums.Min()}");




// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// (array1[0,0]*array2[0,0] + array1[0,1]*array2[1,0] array1[0,0]*array2[0,1] + array1[0,1]*array2[1,1])
// (2*3 + 4*3 2*4 + 4*3)
// (array1[1,0]*array2[0,0] + array1[1,1]*array2[1,0] array1[1,0]*array2[0,1] + array1[1,1]*array2[1,1])
// (3*3 + 2*3 3*4 + 2*3)


// void FillArray(int[,] array1)
// {
//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array1.GetLength(1); j++)
//         {
//             array1[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array1)
// {
//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array1.GetLength(1); j++)
//         {
//             System.Console.Write($"{array1[i, j],3}    ");
//         }

//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }


// int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
// {       
//     if (matrixA.GetLength(1) != matrixB.GetLength(0))
//     {
//         throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
//     }

//     var matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

//     for (var i = 0; i < matrixA.GetLength(0); i++)
//     {
//         for (var j = 0; j < matrixB.GetLength(1); j++)
//         {
//             matrixC[i, j] = 0;

//             for (var k = 0; k < matrixA.GetLength(1); k++)
//             {
//                 matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
//             }
//         }
//     }

//     return matrixC;
// }


// int[,] array1 = new int[2,2];
// int[,] array2 = new int[2,2];
// FillArray(array1);
// PrintArray(array1);
// FillArray(array2);
// PrintArray(array2);
// int[,] array3 = MatrixMultiplication(array1, array2);
// PrintArray(array3);