// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void FillMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 11);
        }
    }
}
void Average(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];
        }
        Console.Write(Math.Round(sum / arr.GetLength(0), 1) + "\t");
    }
}
Console.Write("Введите количество строк: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[a, b];
FillMatrix(array);
PrintMatrix(array);

Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца: ");
Average(array);