

namespace Chainblock.Exceptions;

public static class ChainblockExeptionMessages
{
    public const string TransactionDublicated = "Transaction with id: {0} already added";
    public const string TransactionDoesNotExist = "Transaction with id: {0} does not exist";
    public const string TransactionsWithStatusDoesNotExist = "Transactions with status: {0} does not exist";
}
