// Задача 58: Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// int[,] FirstMatrix = FillArray(2, 2);
// int[,] SecondMatrix = FillArray(2, 2);
// Решил оставить конкретные числа для проверки! Через FillArray тоже работает
int[,] FirstMatrix = { { 2, 4 }, { 3, 2 } };
int[,] SecondMatrix = { { 3, 4 }, { 3, 3 } };
int[,] ThirdMatrix = new int[2, 2];
MultiplyMatrix(FirstMatrix, SecondMatrix, ThirdMatrix);

void MultiplyMatrix(int[,] FirstMatrix, int[,] SecondMatrix, int[,] ThirdMatrix)
{
    for (int i = 0; i < FirstMatrix.GetLength(0); i++)
    { 
        for (int j = 0; j < FirstMatrix.GetLength(0); j++)
        {
            ThirdMatrix[i, j] = FirstMatrix[i, 0] * SecondMatrix[0, j] + FirstMatrix[i, 1] * SecondMatrix[1, j] ;
            System.Console.Write($"{ThirdMatrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     return array;
// }