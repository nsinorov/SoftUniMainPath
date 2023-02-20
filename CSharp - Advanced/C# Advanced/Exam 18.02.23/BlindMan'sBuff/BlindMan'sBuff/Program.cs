//Reading the size of the matrix
int[] size = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string[,] playgroundMatrix = new string[size[0], size[1]];

int blindRow = 0;
int blindCol = 0;
// Filling the matrix
for (int row = 0; row < size[0]; row++)
{
    string[] rowInput = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);


    for (int col = 0; col < size[1]; col++)
    {
        playgroundMatrix[row, col] = rowInput[col].ToString();

        if (playgroundMatrix[row, col] == "B")
        {
            blindRow = row;
            blindCol = col;
            playgroundMatrix[blindRow, blindCol] = "-";

        }
    }
}

string command = string.Empty;

int opponentsTouched = 0;
int movesMade = 0;

while (opponentsTouched != 3 && (command = Console.ReadLine()) != "Finish")
{
    string moveTo = command;
    bool hitObject = false;

    // Moving around the playground
    if (moveTo == "left" && blindCol - 1 >= 0 && playgroundMatrix[blindRow, blindCol - 1] != "O")
    {
        blindCol--;
    }
    else if (moveTo == "right" && blindCol + 1 < size[1] && playgroundMatrix[blindRow, blindCol + 1] != "O")
    {
        blindCol++;
    }
    else if (moveTo == "up" && blindRow - 1 >= 0 && playgroundMatrix[blindRow - 1, blindCol] != "O")
    {
        blindRow--;
    }
    else if (moveTo == "down" && blindRow + 1 < size[0] && playgroundMatrix[blindRow + 1, blindCol] != "O")
    {
        blindRow++;
    }
    else
    {
        hitObject = true;
    }

    if (playgroundMatrix[blindRow, blindCol] == "P")
    {
        opponentsTouched++;
        movesMade++;
        playgroundMatrix[blindRow, blindCol] = "-";

    }

    else if (playgroundMatrix[blindRow, blindCol] == "-" && hitObject != true)
    {
        movesMade++;
    }
}

//Output
Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {opponentsTouched} Moves made: {movesMade}");
