// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

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

int min = array[0];
for(int i = 0; i < array.Length; i++)
{
    if(min > array[i]) min = array[i];
}
int max = array[0];
for(int i = 0; i < array.Length; i++)
{
    if(max < array[i]) max = array[i];
}

Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {max - min}");