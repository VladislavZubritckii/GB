// //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом(зеркальным).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int Number = Convert.ToInt32(Console.ReadLine());

if (checkNum > 9999 && checkNum < 100000)
{
    if (checkNum / 10000 == checkNum % 10 && checkNum / 1000 % 10 == checkNum % 100 / 10)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Это число не пятизначное");
}