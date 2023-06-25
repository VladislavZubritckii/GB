// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
string NumberString = Console.ReadLine();
int NumberInt = Convert.ToInt32(NumberString);
int a = NumberInt;
Console.WriteLine("Введите второе число");
string NumberString2 = Console.ReadLine();
int NumberInt2 = Convert.ToInt32(NumberString2);
int b = NumberInt2;
Console.WriteLine("Введите Третье число");
string NumberString3 = Console.ReadLine();
int NumberInt3 = Convert.ToInt32(NumberString3);
int c = NumberInt3;
if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("Max = " + a);
    }
    else
    {
        Console.WriteLine("Max = " + c);
    }
}

else if (b > c)
{
    Console.WriteLine("Max = " + b);
}
else
{
    Console.WriteLine("Max = " + c);
}
