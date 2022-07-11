//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
Console.Clear();
Console.Write("Введите из скольки элементов будет массив: ");
int Elements = Convert.ToInt32(Console.ReadLine());
int RandomN(int numberElements, int min, int max)
{
    int[] randomNum = new int[numberElements];
    int sum = 0;
    Console.Write("Ваш массив: ");
    for (int i = 0; i < randomNum.Length; i++)
    {
        randomNum[i] = new Random().Next(min, max);
        Console.Write(randomNum[i] + ",");
        if (i % 2 != 1)
        {
            sum = sum + randomNum[i];
        }
    }
    return sum;
}
int randomNumbers = RandomN(Elements, 1, 10);
Console.WriteLine($"\nСумма на нечетных позициях: {randomNumbers}");