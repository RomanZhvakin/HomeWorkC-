//Задача 34: 
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
Console.Clear();
int[] numbers = new int[4];
void Array(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int Positive(int[] array)
{
    int numbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
        {
            numbers++;
        }
    }
    return numbers;
}
Array(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();
int Numbers = Positive(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {Numbers}");