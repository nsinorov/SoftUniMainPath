﻿
int[] dimensions = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).
    ToArray();

int rows = dimensions[0];
int cols = dimensions[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] nums = Console.ReadLine()
        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse).
        ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = nums[col];
    }
}

int maxSum = int.MinValue;
int indexRow = int.MinValue;
int indexCol = int.MinValue;

for (int row = 0; row < rows - 1; row++)
{

    for (int col = 0; col < cols - 1; col++)
    {
        int currentSum = matrix[row, col] + matrix[row, col + 1]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1];

        if (currentSum > maxSum)
        {
            maxSum = currentSum;
            indexRow = row;
            indexCol = col;
        }
    }
}
Console.WriteLine($"{matrix[indexRow, indexCol]} {matrix[indexRow, indexCol + 1]}");
Console.WriteLine($"{matrix[indexRow + 1, indexCol]} {matrix[indexRow + 1, indexCol + 1]}");
Console.WriteLine(maxSum);