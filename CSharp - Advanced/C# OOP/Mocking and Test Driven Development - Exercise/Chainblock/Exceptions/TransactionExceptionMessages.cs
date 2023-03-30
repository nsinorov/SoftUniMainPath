using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chainblock.Exceptions;

public static class TransactionExceptionMessages
{
    public const string idNotPositiveNumber = "Id should be a positive number";
    public const string senderNullOrWhiteSpace = "Sender is null or white space";
    public const string receiverNullOrWhiteSpace = "Receiver is null or white space";
    public const string amountNotPositive = "Amount should be a positive number";



}
