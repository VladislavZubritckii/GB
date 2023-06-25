// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("введите день недели от 1 до 7: ");
int numberday = Convert.ToInt32(Console.ReadLine());


if (numberday > 0 && numberday < 8)
{
    if (numberday == 6 || numberday == 7)
    {
        Console.WriteLine("Да");
    }
    else
    Console.WriteLine ("Нет");
}
else
{
    Console.WriteLine("Вы ввели число не в пределах от 1 до 7");
}