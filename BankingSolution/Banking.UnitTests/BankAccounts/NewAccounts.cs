using Banking.Domain;

namespace Banking.UnitTests.BankAccounts
{
    public class NewAccounts
    {

        [Fact]
        public void NewAccountsHaveCorrectOpeningBalance()
        {
            var account = new BankAccount();

            decimal balance = account.GetBalance();

            Assert.Equal(5000, balance);
        }

        [Fact]
        public void DepositsIncreaseTheBalance()
        {
            // Given
            var account = new BankAccount();
            var openingBalance = account.GetBalance();
            var amountToDeposit = 100.23M;



            // When
            account.Deposit(amountToDeposit);



            // Then
            Assert.Equal(openingBalance + amountToDeposit
                , account.GetBalance());
        }
    }
}
