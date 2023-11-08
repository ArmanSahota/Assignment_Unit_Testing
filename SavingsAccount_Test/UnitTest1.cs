using Microsoft.VisualBasic;

namespace SavingsAccount
{
    [TestClass]
    public class SavingsTest
    {
        [TestMethod]
        public void Withdraw()
        {
            // Arrange
            Savings savingsAccount = new Savings(1000);
            double amountToWithdraw = 200;
            double expectedBalance = 800;

            // Act
            savingsAccount.Withdraw(amountToWithdraw);

            // Assert
            Assert.AreEqual(expectedBalance, savingsAccount.Balance);
        }

        [TestMethod]
        public void WithdrawWithNegativeAmount()
        {
            // Arrange
            Savings savingsAccount = new Savings(1000);
            double amountToWithdraw = -50;
            double expectedBalance = 1000; // Balance should not change with negative withdrawal

            // Act
            savingsAccount.Withdraw(amountToWithdraw);

            // Assert
            Assert.AreEqual(expectedBalance, savingsAccount.Balance);
        }

        [TestMethod]
        public void DepositWithSuccess()
        {
            // Arrange
            Savings savingsAccount = new Savings(1000);
            double amountToDeposit = 200;
            double expectedBalance = 1205; // Initial balance + 5% interest on 1000 + 200

            // Act
            savingsAccount.Deposit(amountToDeposit);

            // Assert
            Assert.AreEqual(expectedBalance, savingsAccount.Balance);
        }

        [TestMethod]
        public void DepositWithNegativeValue()
        {
            // Arrange
            Savings savingsAccount = new Savings(1000);
            double amountToDeposit = -50;
            double expectedBalance = 1000; // Balance should not change with negative deposit

            // Act
            savingsAccount.Deposit(amountToDeposit);

            // Assert
            Assert.AreEqual(expectedBalance, savingsAccount.Balance);
        }
    }
}