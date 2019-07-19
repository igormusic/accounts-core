using System;
using System.Reflection;
using Accounts.Metadata.Model;
using Accounts.Runtime.CodeGeneration;
using Accounts.Runtime.Model;
using NUnit.Framework;

namespace Accounts.Test
{
    public class CompilerTests
    {
        [Test]
        public void CreateLoanType()
        {
            AccountType accountType = TestUtility.CreateSavingsAccountType();

            Assembly assembly = CodeCompiler.Compile(CodeGenerator.GenerateAccountType(accountType));

            Type type = assembly.GetType("Accounts.Runtime.Model." + accountType.ClassName);
            Account account = (Account)Activator.CreateInstance(type);

        }
    }
}
