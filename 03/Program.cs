// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();
Console.Write("Введите количество строк массива: ");

int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");

int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int sum = GetSumDiagonal(array);
Console.WriteLine(sum);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int GetSumDiagonal(int[,] inArray)
{
    int sum = 0;
    // int resolutionMin = Math.Min(array.GetLength(0), array.GetLength(1));
    int size = 0;
    if (inArray.GetLength(0) < inArray.GetLength(1))
    {
        size = inArray.GetLength(0);
    }
    else
    {
        size = inArray.GetLength(1);
    }
    for (int i = 0; i < size; i++)
    {
        sum += inArray[i, i];
    }
    return sum;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}