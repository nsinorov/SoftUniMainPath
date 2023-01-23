int[] dimensions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
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

string input = Console.ReadLine();

while(input != "END")
{
    string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    if (isValidCommand(rows, cols, tokens))
    {
        int tempValue = matrix[int.Parse(tokens[1]), int.Parse(tokens[2])];
        matrix[int.Parse(tokens[1]), int.Parse(tokens[2])] = matrix[int.Parse(tokens[3]), int.Parse(tokens[4])];
        matrix[int.Parse(tokens[3]), int.Parse(tokens[4])] = tempValue;

        PrintMatrix();
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }

    input = Console.ReadLine();
}
bool isValidCommand(int rows, int cols, string[] tokens)
{
    return
        tokens[0] == "swap"
        && tokens.Length == 5
        && int.Parse(tokens[1]) >= 0 && int.Parse(tokens[1]) < rows
        && int.Parse(tokens[2]) >= 0 && int.Parse(tokens[2]) < cols
        && int.Parse(tokens[3]) >= 0 && int.Parse(tokens[3]) < rows
        && int.Parse(tokens[4]) >= 0 && int.Parse(tokens[4]) < cols;
}

void PrintMatrix()
{
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            Console.Write($"{matrix[row, col]} ");
        }

        Console.WriteLine();
    }
}