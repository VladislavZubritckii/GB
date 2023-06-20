// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


Console.WriteLine("Введите число");
string NumberString = Console.ReadLine();
int NumberInt = Convert.ToInt32(NumberString);
int a = NumberInt;
if (a % 2 == 0)
{
    Console.WriteLine("Четное");
}
else 
{
    Console.WriteLine("Нечетное");
}