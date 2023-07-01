

int Number = 8;
int[] array = new int[640000000];
for (int i =1; i < array.Length; i++)
{
    array[i] = Random.Shared.Next(0,2);
    Console.Write(array[i]);
}