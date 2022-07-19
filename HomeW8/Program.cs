//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3


Console.Clear();
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
    string s = new string('*', 30);
    System.Console.WriteLine("" + s);
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (j == 0)
                System.Console.Write(" | ");
            System.Console.Write($"{mtrx[i, j], 4} | ");
        }
        System.Console.WriteLine("");
    }
    System.Console.WriteLine("" + s);
}
void Columns(int[,] matrix)
{
    double count = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            count += matrix[i, j];
        }
        if (j == 0)
            System.Console.WriteLine("Средне арефмитическое по столбцам равно:");
        System.Console.Write($" |  {Math.Round(count / matrix.GetLength(0), 1)}");
        if (j == matrix.GetLength(1) - 1)
            System.Console.Write(" |");
        count = 0;
    }
}
int[,] matrix = GetMatrix(3, 4, 1, 10);
PrintMatrix(matrix);
Columns(matrix);
System.Console.WriteLine();
string s = new string('=', 40);
System.Console.WriteLine("" + s);
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine();