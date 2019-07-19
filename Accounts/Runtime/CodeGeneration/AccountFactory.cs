using System;
using System.Collections.Generic;
using System.Reflection;
using Accounts.Metadata.Model;
using Accounts.Runtime.Model;

namespace Accounts.Runtime.CodeGeneration
{
    public class AccountFactory
    {
        private static readonly object lockObject = new object();

        private static Dictionary<string, Type> types = new Dictionary<string, Type>();

        public static Account CreateAccount(AccountType accountType) {
            
            Type type;

            //multiple threads might be generating types at the same time - do a lock 
            lock (lockObject) {
                if (types.ContainsKey(accountType.ClassName)) {
                    type = types[accountType.ClassName];
                }
                else
                {
                    Assembly assembly = CodeCompiler.Compile(CodeGenerator.GenerateAccountType(accountType));
                    type = assembly.GetType("Accounts.Runtime.Model." + accountType.ClassName);
                    types.Add(accountType.ClassName, type);
                }
            }

            Account account = (Account)Activator.CreateInstance(type);

            return account;
        }
    }
}
