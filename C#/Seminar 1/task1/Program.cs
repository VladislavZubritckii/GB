﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3



Console.WriteLine("Введите первое число");
string NumberString = Console.ReadLine();
Console.WriteLine("Введите второе число");
string NumberString2 = Console.ReadLine();
int NumberInt = Convert.ToInt32(NumberString);
int NumberInt2 = Convert.ToInt32(NumberString2);
int a = NumberInt;
int b = NumberInt2;
if (a > b)
{
    Console.WriteLine("Max = " + a);
    Console.WriteLine("Min = " + b);
}
else 
{
    Console.WriteLine("Max = " + b);
    Console.WriteLine("Min = " + a);
}