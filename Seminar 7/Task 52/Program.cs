﻿// Задайте двумерный массив из целых чисел. Найдите 
// среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

// Console.WriteLine("введите количество строк:");
// int ROWS = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов:");
// int COLUMNS = Convert.ToInt32(Console.ReadLine());

// int[,] GetRandomMatrix( int rows, int columns)
// {
//     int[,] matrix = new int[rows, columns];
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = matrix[i, j] = Random.Shared.Next(1, 10);
//         }
//     }
// return matrix;
// }

// double Average(int[,] matrix)
// {
//     double summa = 0;
//     double average = 0;
//     for(int i = 0; i < matrix.GetLength(1); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(0); j++)
//         {
            
//             summa += matrix[j, i];
    
//         }
//         average = summa / (matrix.GetLength(0));
//         Console.WriteLine((String.Format($"{average:f2}\t")));
//     }
//     return average;    
// }

// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS);
// PrintMatrix(myMatrix);
// Console.WriteLine();
// double average = Average(myMatrix);



int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");
int[,] matrix = FillMatrix(rows, cols, 0, 10);
PrintMatrix(matrix);

double[] sum = new double[cols];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum[j] = sum[j] + matrix[i, j];
    }
}

System.Console.WriteLine("");

for (int i = 0; i < sum.Length; i++)
{
    System.Console.Write(sum[i] / 2 + "\t");
}