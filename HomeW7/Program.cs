//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет


Console.Clear();
System.Console.WriteLine("Введите номер строки: ");
int posI = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите номер столбца: ");
int posJ = int.Parse(Console.ReadLine()!);
int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] mtrx)
{
    string s = new string('*', 35);
    System.Console.WriteLine("" + s);
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (j == 0)
                System.Console.Write(" | ");
            System.Console.Write($"{mtrx[i, j], 5} | ");
        }
        System.Console.WriteLine("");
    }
    System.Console.WriteLine("" + s);
}
int ElementPosition(int[,] mtrx, int posI, int posJ)
{
    int element = 0;
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (i == posI - 1 && j == posJ - 1)
            {
                element = mtrx[i, j];
            }
        }
    }
    return element;
}
int[,] matrix = GetMatrix(3, 4, 1, 10);
PrintMatrix(matrix);
if (ElementPosition(matrix, posI, posJ) > 0)
{
    System.Console.WriteLine(
        "Ваш элемент: " + ElementPosition(matrix, posI, posJ)
    );
}
else
{
    System.Console.WriteLine("Такого элемента нет в таблице, провертье вводимые данные!!!");
}