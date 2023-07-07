﻿// Задайте одномерный массив, заполненный случайными
//  числами. Найдите сумму элементов, стоящих на 
//  нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetRandomArray()
{
    Console.WriteLine("Введите длину массива: ");
    int[] array = new int[Convert.ToInt32(Console.ReadLine())];
    Console.WriteLine("Введите нижнюю границу массива: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите верхнюю границу массива: ");
    int b = Convert.ToInt32(Console.ReadLine());
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(a, b);
    }
    return array;
}
int[] array = GetRandomArray();
Console.WriteLine($"Случайный массив {string.Join(", ", array)}");
int sum = 0;
for(int i = 1; i < array.Length; i++)
{
    if(i % 2 != 0) sum = array[i] + sum;
}
 Console.WriteLine($"Сумма нечетных цифр массива = {sum}");