// Задача 54: Задайте двумерный массив. Напишите программу
//    которая упорядочит по убыванию элементы каждой строки двумерного массива.
//   Например, задан массив:
//   1 4 7 2
//   5 9 2 3
//   8 4 2 4
//   В итоге получается вот такой массив:
//   7 4 2 1
//   9 5 3 2
//   8 4 4 2
Console.WriteLine("Select hight of matrix");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Select lenght of matrix");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

int[,] array = FillArray(m, n);
int[,] SortedArray = new int[array.GetLength(0), array.GetLength(1)];
PrintArray(SortArray(array));


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

int[,] SortArray(int[,] array)
{
    System.Console.WriteLine("SortedArray");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int[] temp = new int[array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp[j] = array[i, j];
            Array.Sort(temp);
            Array.Reverse(temp);
        }
        for (int k = 0; k < array.GetLength(1); k++)
        {
            SortedArray[i, k] = temp[k];
        }
    }
    return SortedArray;
}

void PrintArray(int[,] newarray)
{
    for (int i = 0; i < SortedArray.GetLength(0); i++)
    {
        for (int j = 0; j < SortedArray.GetLength(1); j++)
        {
            Console.Write($"{SortedArray[i, j]} ");
        }
        System.Console.WriteLine();
    }
}