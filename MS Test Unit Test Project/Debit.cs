internal class Program
{
    private static void Main(string[] args)
    {
        [TestMethod] Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange.
to the new method.

e()
{
    // Arrange
    double beginningBalance = 11.99;
    double debitAmount = -100.00;
    BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

    // Act and assert
    Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));}
if (amount > m_balance)
        {
            throw new System.ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
        }

        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("amount", amount, DebitAmountLessThanZeroMessage);
        }
    }

    private void debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange { get => debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange; set => debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange = value; }
}
[TestMethod]
public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
{
    // Arrange
    double beginningBalance = 11.99;
    double debitAmount = 20.0;
    BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

    // Act
    try
    {
        account.Debit(debitAmount);
    }
    catch (System.ArgumentOutOfRangeException e)
    {
        // Assert
        StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
    }
}
[TestMethod]
public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
{
    // Arrange
    double beginningBalance = 11.99;
    double debitAmount = 20.0;
    BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

    // Act
    try
    {
        account.Debit(debitAmount);
    }
    catch (System.ArgumentOutOfRangeException e)
    {
        // Assert
        StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
        return;
    }

    Assert.Fail("The expected exception was not thrown.");
}