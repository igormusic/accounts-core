using System;
using Accounts.Metadata.Model;
using Accounts.Runtime.Commands;
using Accounts.Runtime.Model;

namespace Accounts.Runtime.Service
{
    public interface IAccountService
    {
        Account CreateAccount(CreateAccountCommand command);
    }
}
