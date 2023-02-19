// HW7.
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// double [,] CreatRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     double [,] array = new double [rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i,j] = Math.Round(new Random ().Next(minValue, maxValue + 1) + new Random().NextDouble(),2);
//         }
//     }
//     return array;
// }

// void Show2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Input a number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of minValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// double[,] newArray = CreatRandom2dArray(rows,columns,minValue,maxValue);
// Show2dArray(newArray);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:

// int [,] CreatRandom2dArray()
// {
//     Console.Write("Input a number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of minValue: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of maxValue: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
    
//     int [,] array = new int [rows,columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i,j] = new Random().Next(minValue,maxValue+1);
//         }
//     }
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int FindValue (int [,]array, int i, int j)
// {
//     if(i > array.GetLength(0) || j>array.GetLength(1))
//         return -1;
//     else return array[i,j];
// }

// int [,] myArray = CreatRandom2dArray();
// Show2dArray(myArray);

// Console.Write("Input a number of i: ");
// int indexI = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of j: ");
// int indexJ = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(FindValue(myArray, indexI, indexJ));

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:

int [,] CreatRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of minValue: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of maxValue: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int [,] array = new int [rows,columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue,maxValue+1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i],3) + " ");
    Console.WriteLine();
}

double [] Average(int [,] array)
{
    double [] average = new double [array.GetLength(1)];
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum+array[i,j];
            average[i]=sum/(array.GetLength(0)+1);
        }
        return average;
}

int [,] myArray = CreatRandom2dArray();
Show2dArray(myArray);
double[] newArray = Average(myArray);
ShowArray(newArray);
