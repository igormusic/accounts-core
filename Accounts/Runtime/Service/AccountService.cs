using System;
using Accounts.Metadata.Model;
using Accounts.Runtime.CodeGeneration;
using Accounts.Runtime.Commands;
using Accounts.Runtime.Model;

namespace Accounts.Runtime.Service
{
    public class AccountService : IAccountService
    {
        public Account CreateAccount(CreateAccountCommand command)
        {
            Account account = AccountFactory.CreateAccount(command.AccountType);

            account.InitializePositions();

            return account;
        }
    }
}
