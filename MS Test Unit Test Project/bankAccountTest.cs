// The 'using' statement for Test Tools is in GlobalUsings.cs
// using BankAccounts;

using BankAccountNS;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests : IBankAccountTests
    {
        private double actual;
        private int amount;

        public int m_balance { get; private set; }

        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            m_balance += amount;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly")
                }
    }
