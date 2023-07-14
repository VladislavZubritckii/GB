//  Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого
//  элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 2

int[,] GetRandomMatrix( int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = matrix[i, j] = Random.Shared.Next(1, 20);
        }
    }
return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] myMatrix = GetRandomMatrix(5, 5);
PrintMatrix(myMatrix);

Console.WriteLine("введите строку позиции числа:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите столбец позиции числа:");
int b = Convert.ToInt32(Console.ReadLine());

int Number(int[,] matrix)
{
    int number = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == (a - 1) && j == (b - 1))
            {
                number = matrix[i, j];
            }
        }
    }
    return number;    
}

if(a > 5 || b > 5)
{
    Console.WriteLine("Число, на указанной позиции не найдено");
}
else
{
int number = Number(myMatrix);
Console.WriteLine($"Число, на указанной позиции:{number}");
}