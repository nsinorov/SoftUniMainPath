int sizeOfMatrix = int.Parse(Console.ReadLine());

int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];

for (int row = 0; row < sizeOfMatrix; row++)
{
    string input = Console.ReadLine();

    for (int col = 0; col < sizeOfMatrix; col++)
    {
        matrix[row, col] = input[col];
    }
}

char symbol = char.Parse(Console.ReadLine());

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (matrix[row, col] == symbol)
        {
            Console.WriteLine($"({row}, {col})");
            return;
        }
    }
}
Console.WriteLine($"{symbol} does not occur in the matrix");