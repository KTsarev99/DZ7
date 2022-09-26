// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("укажите позицию элемента в двумерном массиве");
Console.WriteLine("введите  индекс строки");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите  индекс столбца");
int n = Convert.ToInt32(Console.ReadLine());


int[,] array = new int   [4,5]  {{1,6,8,5,4},
                                {9,2,3,1,4},
                                {3,1,7,5,4},
                                {6,5,3,9,4},};

if(m<=3&&m>=0 && n>=0&&n<=4)
{
    for(int i=0;i<array.GetLength(0);i++)
{
    for(int j=0;j<array.GetLength(1); j++)  
        {
        Console.Write("это число - ");
        Console.Write(array[m,n]);
        break;
        } 
        break;
}
}
else
{
Console.Write("такого числа нет в массиве");
}


