﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int   [4,5]  {{1,6,8,5,4},
                                {9,2,3,1,4},
                                {3,1,7,5,4},
                                {6,5,3,9,4},};

for(int j=0; j < array.GetLength(1);j++)
{
    double sum =0;
    Console.Write("  ");
    for(int i=0;i<array.GetLength(0);i++)
    {
        sum=sum+array[i,j];   
    }
    Console.Write(sum / array.GetLength(0));
}
