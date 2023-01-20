
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
        .Split(", ",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse).
        ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = nums[col];
    }
}

int sum = 0;

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        sum += matrix[row, col];
    }
}

Console.WriteLine(dimensions[0]);
Console.WriteLine(dimensions[1]);
Console.WriteLine(sum);