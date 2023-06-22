﻿// Задача 47. Задайте двумерный массив 
// размером m×n, заполненный случайными 
// вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// int rows = Convert.ToInt32(Console.ReadLine());
// int colomns = Convert.ToInt32(Console.ReadLine());

// double[,] array = new double[rows,colomns];

// // Цикл заполняет массив

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = Convert.ToDouble (new Random().Next(-100,100)) / 10;
//     }
// }

// // Цикл выводит массив

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i,j]+ " ");
//     }
//     Console.WriteLine();
// }


// *******************************************************************************************


// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет




// int rows = ReadInt("Введите индекс строки: ");
// int colums = ReadInt("Введите индекс столбца: ");
// int[,] numbers = new int[6, 8];
// FillArray(numbers);
// PrintArray(numbers);

// if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
// else Console.WriteLine($"Такого числа в массиве нет");

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }



// **************************************************************************************************



// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int colomns = Convert.ToInt32(Console.ReadLine());

int [,] array = new int[rows,colomns];

void Array()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
         {
               array[i,j] = new Random().Next(1,10);
         }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
               Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

void AvarageArray()
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
              avarage = (avarage + array[i, j]);
        }
        avarage = avarage / rows;
        Console.Write(avarage + "; ");
}
}
Array();
PrintArray();
Console.WriteLine();
 Console.WriteLine("Среднее арефметическое столбцов:");
AvarageArray();
