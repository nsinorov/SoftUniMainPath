using Chainblock.Enums;
using Chainblock.Exceptions;
using Chainblock.Models;
using Chainblock.Models.Interfaces;
using NUnit.Framework;
using System;

namespace Chainblock.Tests;

[TestFixture]
public class TransactionTests
{
    [Test]
    public void Test_ConstructorShouldInitializeProperly()
    {

        ITransaction transaction = new Transaction(1, TransactionStatus.Successfull, "Pesho", "Gosho", 1000);

        Assert.IsNotNull(transaction);
    }

    [Test] 
    public void Test_ConstructorShouldInitialize_Id()
    {
        // Arrange
        int expectedId = 1;

        //Act
        ITransaction transaction = new Transaction(expectedId, TransactionStatus.Successfull, "Pesho", "Gosho", 1000);

        //Assert
        Assert.AreEqual(expectedId, transaction.Id);
    }

    [Test]
    public void Test_ConstructorShouldInitialize_StatusProperty()
    {
        // Arrange
        TransactionStatus expectedStatus = TransactionStatus.Unauthorised;

        //Act
        ITransaction transaction = new Transaction(1, expectedStatus, "Pesho", "Gosho", 1000);

        //Assert
        Assert.AreEqual(expectedStatus, transaction.Status);
    }

    [Test]
    public void Test_ConstructorShouldInitialize_From()
    {
        // Arrange
        string expectedSender = "Pesho";

        //Act
        ITransaction transaction = new Transaction(1, TransactionStatus.Successfull, expectedSender, "Gosho", 1000);

        //Assert
        Assert.AreEqual(expectedSender, transaction.From);
    }

    [Test]
    public void Test_ConstructorShouldInitialize_To()
    {
        // Arrange
        string expectedReceiver = "Gosho";

        //Act
        ITransaction transaction = new Transaction(1, TransactionStatus.Successfull, "Pesho", expectedReceiver, 1000);

        //Assert
        Assert.AreEqual(expectedReceiver, transaction.To);
    }

    [Test]
    public void Test_ConstructorShouldInitialize_Amount()
    {
        // Arrange
        decimal expectedAmount = 1000;

        //Act
        ITransaction transaction = new Transaction(1, TransactionStatus.Successfull, "Pesho", "Gosho", expectedAmount);

        //Assert
        Assert.AreEqual(expectedAmount, transaction.Amount);
    }

    [TestCase(-1)]
    [TestCase(-100)]
    [TestCase(0)]
    public void Test_IdSetterShouldThrowExeptionWithZeroOrNegativeId(int id)
    {

        ArgumentException exception = Assert.Throws<ArgumentException>(() => new Transaction(id, TransactionStatus.Aborted, "Gosho", "Pesho", 100));

        Assert.AreEqual(TransactionExceptionMessages.idNotPositiveNumber, exception.Message);
    }

    // We can skip TransactonStatus tests -> nothing can go wrong.

    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    [TestCase("         ")]
    public void Test_SenderSetterShouldThrowExeptionWithNullOrWiteSpaceString(string from)
    {

        ArgumentException exception = Assert.Throws<ArgumentException>(() => new Transaction(1, TransactionStatus.Aborted, from, "Pesho", 100));

        Assert.AreEqual(TransactionExceptionMessages.senderNullOrWhiteSpace, exception.Message);
    }


    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    [TestCase("         ")]
    public void Test_ReceiverSetterShouldThrowExeptionWithNullOrWiteSpaceString(string to)
    {

        ArgumentException exception = Assert.Throws<ArgumentException>(() => new Transaction(1, TransactionStatus.Aborted, "Pesho", to, 100));

        Assert.AreEqual(TransactionExceptionMessages.receiverNullOrWhiteSpace, exception.Message);
    }


    [TestCase(-100)]
    [TestCase(-0.000000001)]
    [TestCase(0)]
    public void Test_AmountSetterShouldThrowExeptionWithZeroOrNegativeId(decimal amount)
    {

        ArgumentException exception = Assert.Throws<ArgumentException>(() => new Transaction(1, TransactionStatus.Aborted, "Gosho", "Pesho", amount));

       Assert.AreEqual(TransactionExceptionMessages.amountNotPositive, exception.Message);
    }
}