string[] accountsInput = Console.ReadLine().Split(',');

Dictionary<int, double> accounts = new();

foreach (string accountInput in accountsInput)
{
    string[] parts = accountInput.Split('-');
    int accountNumber = int.Parse(parts[0]);
    double accountBalance = double.Parse(parts[1]);
    accounts[accountNumber] = accountBalance;
}

// Process commands
while (true)
{
    string[] command = Console.ReadLine().Split();

    if (command[0] == "End")
    {
        break;
    }

    int accountNumber = int.Parse(command[1]);

    if (!accounts.ContainsKey(accountNumber))
    {
        Console.WriteLine("Invalid account!");
        Console.WriteLine("Enter another command");

        continue;
    }

    switch (command[0])
    {
        case "Deposit":
            double depositAmount = double.Parse(command[2]);
            accounts[accountNumber] += depositAmount;
            Console.WriteLine("Account {0} has new balance: {1:F2}", accountNumber, accounts[accountNumber]);
            break;

        case "Withdraw":
            double withdrawAmount = double.Parse(command[2]);
            if (withdrawAmount > accounts[accountNumber])
            {
                Console.WriteLine("Insufficient balance!");
            }
            else
            {
                accounts[accountNumber] -= withdrawAmount;
                Console.WriteLine("Account {0} has new balance: {1:F2}", accountNumber, accounts[accountNumber]);
            }
            break;

        default:
            Console.WriteLine("Invalid command!");
            break;
    }
    Console.WriteLine("Enter another command");
}