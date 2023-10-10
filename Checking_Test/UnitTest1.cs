namespace Checking_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Withdraw0OD()
        {
          // arrange
          Checking testChecking = new Checking(500);
            double amountToWithdraw = 300;
            double expectedBalance = 200;


            // Act
            testChecking.Withdraw(amountToWithdraw);

            // Assert
            Assert.AreEqual(expectedBalance, testChecking.Balance );
        }


    
        [TestMethod]
        public void WithdrawWODCharge()
        {
            // Arrange
            Checking checkingAccount = new Checking(100);
            double amountToWithdraw = 200;
            double expectedBalance = -115; // 100 - 200 - 15 (overdraft charge)

            // Act
            checkingAccount.Withdraw(amountToWithdraw);

            // Assert
            Assert.AreEqual(expectedBalance, checkingAccount.Balance);
        }

        [TestMethod]
        public void DepositWithSuccess()
        {
            // Arrange
            Checking checkingAccount = new Checking(500);
            double amountToDeposit = 200;
            double expectedBalance = 700;

            // Act
            checkingAccount.Deposit(amountToDeposit);

            // Assert
            Assert.AreEqual(expectedBalance, checkingAccount.Balance);
        }

        [TestMethod]
        public void DepositWithNegativeValue()
        {
            // Arrange
            Checking checkingAccount = new Checking(500);
            double amountToDeposit = -50;
            double expectedBalance = 500; // Balance should not change with negative deposit

            // Act
            checkingAccount.Deposit(amountToDeposit);

            // Assert
            Assert.AreEqual(expectedBalance, checkingAccount.Balance);
        }
    }
}
