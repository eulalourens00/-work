using UniTests_Модульное_Тестирование;
namespace TestProject1
{
    [TestClass]
    public sealed class BankAccountTest
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdayesBalance()
        {
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;

            BankAccount account = new BankAccount("Leeky", beginningBalance);
            account.Debit(debitAmount);
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");

        }
        [TestMethod]
        public void Debit_WithValidAmount_Zero()
        {
            double beginningBalance = 11.99;
            double debitAmount = -1000.00;
            BankAccount account = new BankAccount("Suya", beginningBalance);

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }
    }
}
