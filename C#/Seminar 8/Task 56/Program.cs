// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
const int rows = 4;
const int columns = 4;

int[,] GetRandomArray(int rows, int columns)
{
    int[,] a = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            a[i, j] = Random.Shared.Next(1, 10);
        }
    return a;
}

int NumberOfStringInArray(int[,] Matrix)
{
    int SumMinimal = int.MaxValue;
    int indexToMinRowSum = 0;
    for (int i = 0; i < rows; ++i)
    {
        int MinAcrossRow = 0;
        for (int j = 0; j < columns; ++j)
        {
            MinAcrossRow += Matrix[i, j];
        }
        if (MinAcrossRow < SumMinimal)
        {
            SumMinimal = MinAcrossRow;
            indexToMinRowSum = i;
        }
    }
    return indexToMinRowSum;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] matr = GetRandomArray(rows, columns);
PrintMatrix(matr);
Console.WriteLine(NumberOfStringInArray(matr));