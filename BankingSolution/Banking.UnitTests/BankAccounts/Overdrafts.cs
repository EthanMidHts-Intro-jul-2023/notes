using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests.BankAccounts
{
    public class Overdrafts
    {
        [Fact]
        public void BadCurrentBehavior()
        {
            var account = new BankAccount();
            var openingBalance = account.GetBalance();
            var amountToWithdraw = openingBalance + .01M;



            account.Withdraw(amountToWithdraw);



            Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());



        }



        [Fact]
        public void NewBehavior()
        {
            var account = new BankAccount();
            var openingBalance = account.GetBalance();
            var amountToWithdraw = openingBalance + .01M;



            account.Withdraw(amountToWithdraw);



            Assert.Equal(openingBalance, account.GetBalance());
        }
    }
}
