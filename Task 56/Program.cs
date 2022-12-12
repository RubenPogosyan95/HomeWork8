// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка
Console.WriteLine("Select hight of matrix");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Select lenght of matrix");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

int[,] array = FillArray(m,n);
int[] newArray = new int[array.GetLength(0)];
FindMax(SumLine(array));

int[] SumLine(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        newArray[i] = sum;
        System.Console.Write($"{newArray[i]} ");
    }
    return newArray;
}

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}

void FindMax(int[] arr)
{
    int max = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[max] < newArray[i])
        {
            max = i;
        }
    }
    System.Console.WriteLine();
    System.Console.Write($"MaxLine = {max + 1}");
}