// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//    Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//    Массив размером 2 x 2 x 2
//    66(0,0,0) 25(0, 1, 0)
//    34(1, 0, 0) 41(1, 1, 0)
//    27(0, 0, 1) 90(0, 1, 1)
//    26(1, 0, 1) 55(1, 1, 1)

// Работает с любыми размерами и Оставил диапазон 90-100 чтобы числа повторялись!!
var random = new Random();
PrintArray(ArrayToLine(FillArray(2, 2, 2)));

int[,,] FillArray(int m, int n, int l)
{
    System.Console.Write("Old-Massiv ");
    int[,,] array = new int[m, n, l];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = random.Next(90, 100);
                Console.Write($"{array[i, j, k]} ");
            }
        }
    }
    return array;
}

int[,,] ArrayToLine(int[,,] array)
{
    int index = 0;
    System.Console.WriteLine();
    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                temp[index] = array[i, j, k];
                index++;
            }
        }
    }
    System.Console.WriteLine();
    CheckLine(temp);
    LineToArray(array, temp);
    return array;
}

int[] CheckLine(int[] temp)
{
    Array.Sort(temp);
    for (int i = 0; i < temp.Length - 1; i++)
    {
        if (temp[i] == temp[i + 1])
        {
            temp[i] = random.Next(10, 100);
        }
    }
    Array.Sort(temp);
    return temp;
}

int[,,] LineToArray(int[,,] array, int[] temp)
{
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = temp[index];
                index++;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    System.Console.WriteLine("NewSorted-Massive with indexes");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}
