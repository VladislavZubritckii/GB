// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



int vvod (string message)
{
    Console.WriteLine("Введите число:");
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

int SummaDigit(int number1)
{
    int result = 0;
    while (number1 > 0)
    {
        result += number1 % 10;
        number1 = number1 / 10;

    }
    return result;
}

int number = vvod ("Введите число: ");
System.Console.WriteLine($"Сумма всех чисел в цифре {number}  = {SummaDigit(number)}");

