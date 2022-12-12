// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int endRows = 5;
int endColums = 5;
int[,] array = new int[endRows, endColums];
int count = 0;
int newRows = 0;
int newColums = 0;
int x = 1;
int y = 1;
int border = 0;
array = FillArray(array, endRows, endColums, count, newRows, newColums, x, y, border).Item1; 
count = FillArray(array, endRows, endColums, count, newRows, newColums, x, y, border).Item2;
PrintArray(array,count);

(int[,], int) FillArray(int[,] array, int rows, int colums, int count, int newRows, int newColums, int x, int y, int border)
{
    for (int i = 0; i < colums; i++)
    {
        array[newRows, newColums] = count;
        count++;
        newColums++;
    }
    newRows++;
    newColums--;
    for (int j = 0; j < rows - 1; j++)
    {
        array[newRows, newColums] = count;
        count++;
        newRows++;
    }
    newRows--;
    newColums--;
    for (int k = 0; k < colums - 1; k++)
    {
        array[newRows, newColums] = count;
        count++;
        newColums--;
    }
    newColums = border;
    newRows--;
    for (int l = 0; l < rows - 2; l++)
    {
        array[newRows, newColums] = count;
        count++;
        newRows--;
    }
    x = x * 2;
    y = y * 2;
    if (colums <= 0) return (array, count);
    return FillArray(array, rows - x, colums - y, count, 1, 1, x, y, border + 1);
}

void PrintArray(int[,] array, int count)
{
    if (endColums == 5) array[array.GetLength(0)/2,array.GetLength(1)/2] = count;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                System.Console.Write($"0{array[i, j]} ");
            }
            else System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}