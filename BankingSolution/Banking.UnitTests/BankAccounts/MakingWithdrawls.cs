using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests.BankAccounts
{
    public class MakingWithdrawls
    {
        [Fact]
        public void MakingAWithdrawalDecreasesTheBalance()
        {
            var account = new BankAccount();
            var openingBalance = account.GetBalance();
            var amountToWithdraw = 1.01M;

            account.Withdraw(amountToWithdraw);
            Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
        }
    }
}
