int sizeOfMatrix = int.Parse(Console.ReadLine());

int primaryDiagonal = 0;

int[,] square = new int[sizeOfMatrix, sizeOfMatrix];

for (int row = 0; row < sizeOfMatrix; row++)
{
    int[] values = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

	for (int col = 0; col < sizeOfMatrix; col++)
	{
        square[row, col] = values[col];
    }
}

for (int i = 0; i < sizeOfMatrix; i++)
{
    primaryDiagonal += square[i, i];
}

Console.WriteLine(primaryDiagonal);