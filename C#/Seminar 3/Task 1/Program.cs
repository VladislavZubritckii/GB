// //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом(зеркальным).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number > 9999 && Number < 100000)
{
    if (Number / 10000 == Number % 10 && Number / 1000 % 10 == Number % 100 / 10)
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