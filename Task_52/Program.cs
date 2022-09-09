/*   ==>  Задача 52.   <== 
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.        */

int[,] GetArray(int m, int n) // заполняет двумерный массив случайными числами от 1 до 9
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(1, 10);
        }
    }
    return res;
}

void PrintArray(int[,] array) // выводит в консоль двумерный массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void AverageValue(int[,] array) // cреднее арифметическое каждого столбца двумерного массива
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double averageValue = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        averageValue = sum / array.GetLength(0);
        Console.Write($"{Math.Round(averageValue, 1)}; ");
    }
}

int[,] array = GetArray(3, 5);
PrintArray(array);
AverageValue(array);