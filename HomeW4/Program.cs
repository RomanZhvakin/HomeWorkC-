// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
Console.Clear();
Console.Write("Введи из скольки чисел будет массив ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];
void InputNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введи число {i + 1}: ");
        massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int Comparison(int[] massiveNumbers)
{
    int count = 0;
    for (int i = 0; i < massiveNumbers.Length; i++)
    {
        if (massiveNumbers[i] > 0) count += 1;
    }
    return count;
}
InputNumbers(m);
Console.WriteLine($"Введено чисел больше 0: ");
Console.WriteLine($"{Comparison(massiveNumbers)}");