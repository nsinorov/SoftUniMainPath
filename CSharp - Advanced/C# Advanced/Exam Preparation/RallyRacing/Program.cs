int size = int.Parse(Console.ReadLine());

string carNumber = Console.ReadLine();

string[,] matrix = new string[size, size];

ReadingMatrix(size, matrix);

bool isFirstTunnelFound = false;
int firstTunnelRow = 0;
int firstTunnelCol = 0;

int secondTunnelRow = 0;
int secondTunnelCol = 0;

for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        if (matrix[row, col] == "T" && !isFirstTunnelFound)
        {
            firstTunnelRow = row;
            firstTunnelCol = col;
            isFirstTunnelFound = true;
        }
        else if (matrix[row, col] == "T")
        {
            secondTunnelRow = row;
            secondTunnelCol = col;
        }
    }
}

string command = Console.ReadLine().ToLower();
int carRow = 0;
int carCol = 0;
int kms = 0;
bool isFinished = false;

while (command != "end")
{
    switch (command)
    {
        case "up": carRow--; break;
        case "down": carRow++; break;
        case "left": carCol--; break;
        case "right": carCol++; break;
    }

    if (matrix[carRow, carCol] == ".")
    {
        kms += 10;
    }
    if (matrix[carRow, carCol] == "T")
    {
        matrix[carRow, carCol] = ".";
        if (carRow == firstTunnelRow && carCol == firstTunnelCol)
        {
            carRow = secondTunnelRow;
            carCol = secondTunnelCol;
        }
        else
        {
            carRow = firstTunnelRow;
            carCol = firstTunnelCol;
        }

        matrix[carRow, carCol] = ".";
        kms += 30;
    }
    if (matrix[carRow, carCol] == "F")
    {
        kms += 10;
        isFinished = true;
        break;
    }
    command = Console.ReadLine().ToLower();
}

matrix[carRow, carCol] = "C";

if (isFinished) 
{
    Console.WriteLine($"Racing car {carNumber} finished the stage!");
}
else
{
    Console.WriteLine($"Racing car {carNumber} DNF.");
}

Console.WriteLine($"Distance covered {kms} km.");

PrintingMAtrix(size, matrix);

static void ReadingMatrix(int size, string[,] matrix)
{
    for (int row = 0; row < size; row++)
    {
        string[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        for (int col = 0; col < size; col++)
        {
            matrix[row, col] = rowData[col];
        }
    }
}

static void PrintingMAtrix(int size, string[,] matrix)
{
    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            Console.Write(matrix[row, col]);
        }
        Console.WriteLine();
    }
}