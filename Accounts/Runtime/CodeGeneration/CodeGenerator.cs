using System;
using Accounts.Metadata.Model;
using Accounts.Runtime.Model;
using Accounts.Utilities;
using HandlebarsDotNet;

namespace Accounts.Runtime.CodeGeneration
{
    public static class CodeGenerator
    {
        public static string GenerateAccountType(AccountType accountType)
        {
            var source =  Utility.ReadManifestData<Account>("AccountTemplate.mustache");

            var template = Handlebars.Compile(source);

            var result = template(accountType);

            return result;
        }
    }
}
