using System;
using Accounts.Metadata.Model;
using Accounts.Runtime.Commands;
using Accounts.Runtime.Model;
using Accounts.Runtime.Service;
using NUnit.Framework;

namespace Accounts.Test
{
    public class AccountTests
    {
        [Test]
    public void ProcessTransaction_deposit()
        {

            AccountType savingsAccountType = TestUtility.CreateSavingsAccountType();

            IAccountService service = new AccountService();

            var account = service.CreateAccount(new CreateAccountCommand() { AccountType = savingsAccountType});

            account.CreateTransaction("Deposit", 100);

            Position currentPosition = account.Positions["Current"];

            Assert.AreEqual (100, currentPosition.Amount );
        }
    }
}
