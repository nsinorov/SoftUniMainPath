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
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse).
        ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = nums[col];     
    }
}

for (int col = 0; col < cols; col++)
{
    int sum = 0;
    for (int row = 0; row < rows; row++)
    {
        sum += matrix[row, col];
    }
    Console.WriteLine(sum);
}