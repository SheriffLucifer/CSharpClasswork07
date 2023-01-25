// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:     Новый массив будет выглядеть 
//                       вот так:   
// 1 4 7 2               1 4 7 2
// 5 9 2 3               5 81 2 9
// 8 4 2 4               8 4 2 4

Console.Clear();
Console.Write("Введите количество строк массива: ");

int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");

int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine("--------------------");

int[,] newArray = CheckArray(array);
PrintArray(newArray);

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

int[,] CheckArray(int[,] inArray)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                result[i, j] = array[i, j] * array[i, j];
            }
            else
            {
                result[i, j] = array[i, j];
            }
        }
    }
    return result;
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