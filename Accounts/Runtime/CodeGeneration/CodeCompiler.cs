using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Accounts.Runtime.Model;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;

namespace Accounts.Runtime.CodeGeneration
{
    public class CodeCompiler
    {
        public static Assembly Compile(String code)
        {
            var syntaxTree = CSharpSyntaxTree.ParseText(code);
            string assemblyName = Guid.NewGuid().ToString();
            var references = GetAssemblyReferences();
            Assembly assembly;
            var compilation = CSharpCompilation.Create(
                assemblyName,
                new[] { syntaxTree },
                references,
                new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary,
                optimizationLevel: OptimizationLevel.Release));

            using (var ms = new MemoryStream())
            {
                var result = compilation.Emit(ms);
                ThrowExceptionIfCompilationFailure(result);
                ms.Seek(0, SeekOrigin.Begin);
                assembly = System.Runtime.Loader.AssemblyLoadContext.Default.LoadFromStream(ms);

            }

            return assembly;
        }

        private static IEnumerable<MetadataReference> GetAssemblyReferences()
        {
            var assemblyPath = Path.GetDirectoryName(typeof(object).Assembly.Location);

            var references = new List<MetadataReference>();

            references.Add(MetadataReference.CreateFromFile(typeof(Account).GetTypeInfo().Assembly.Location));
            references.Add(MetadataReference.CreateFromFile(typeof(object).GetTypeInfo().Assembly.Location));

            string longName = "System.Collections, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

            Assembly assemCollec = Assembly.Load(longName);

            references.Add(MetadataReference.CreateFromFile(assemCollec.Location));

        /* 
        * Adding some necessary .NET assemblies
        * These assemblies couldn't be loaded correctly via the same construction as above,
        * in specific the System.Runtime.
        */
            references.Add(MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "mscorlib.dll")));
            references.Add(MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.dll")));
            references.Add(MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Core.dll")));
            references.Add(MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Runtime.dll")));

            return references;
        }

        private static void ThrowExceptionIfCompilationFailure(EmitResult result)
        {
            if (!result.Success)
            {
                var compilationErrors = result.Diagnostics.Where(diagnostic =>
                        diagnostic.IsWarningAsError ||
                        diagnostic.Severity == DiagnosticSeverity.Error)
                    .ToList();
                if (compilationErrors.Any())
                {
                    var firstError = compilationErrors.First();
                    var errorNumber = firstError.Id;
                    var errorDescription = firstError.GetMessage();
                    var firstErrorMessage = $"{errorNumber}: {errorDescription};";
                    throw new Exception($"Compilation failed, first error is: {firstErrorMessage}");
                }
            }
        }
    }
}
