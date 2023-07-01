// Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int vvod()
{
Console.WriteLine("Введите число:");
int Number = Convert.ToInt32(Console.ReadLine());
return Number;
}
int A = vvod();
int B = vvod();
int result = 1;
for(int i = 1; i <= B; i++)
{
    result = result * A;
}
Console.WriteLine(result);





