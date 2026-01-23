using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Text;

namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit { }
}

namespace SourceGenerator
{
    static class IncrementalGeneratorUtils
    {
        public static int RegexIndexOf(this string str, string pattern)
        {
            var m = Regex.Match(str, pattern);
            return m.Success ? m.Index : -1;
        }

        public static IEnumerable<T> FastReverse<T>(this ImmutableArray<T> items)
        {
            for (int i = items.Length; i >= 0; i--)
            {
                yield return items[i];
            }
        }
    }

    [Generator]
    public class IncrementalGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
#if DEBUG
            System.Diagnostics.Debugger.Launch();
#endif

            var tryCatchCalls = context.SyntaxProvider.CreateSyntaxProvider(
               predicate: (s, t) => s is InvocationExpressionSyntax
               {
                   Expression: MemberAccessExpressionSyntax
                   {
                       Name.Identifier.ValueText: "Catch"
                   } 
               } || s is InvocationExpressionSyntax
               {
                   Expression: IdentifierNameSyntax
                   {
                       Identifier.Text: "Try"
                   }
               },
               transform: GetCallInfo).Collect();

            context.RegisterSourceOutput(tryCatchCalls, Execute);
        }

        private static CallInfo GetCallInfo(GeneratorSyntaxContext context, CancellationToken ct)
        {
            var invocation = (InvocationExpressionSyntax)context.Node;

            var invocationString = invocation.ToString();

            var temp = context.SemanticModel.GetSymbolInfo(invocation);

            var symbol = context.SemanticModel.GetSymbolInfo(invocation).Symbol as IMethodSymbol;
            var type = context.SemanticModel.GetTypeInfo(invocation);

            var test2 = context.SemanticModel.GetDeclaredSymbol(invocation);

            var location = invocation.GetLocation();
            var treeAsString = location.SourceTree.ToString();
            var lineSpan = location.GetLineSpan();
            var mappedLineSpan = location.GetMappedLineSpan();

            var firstArg = invocation.ArgumentList.Arguments.First().ChildNodes().First();
            var strFirstArg = firstArg.ToString();
            var typeForFirstArg = context.SemanticModel.GetTypeInfo(firstArg);
            var symbolForFirstArg = context.SemanticModel.GetSymbolInfo(firstArg);
            var declaredSymbolForFirstArg = context.SemanticModel.GetDeclaredSymbol(firstArg);

            var isMethod = symbolForFirstArg.Symbol is IMethodSymbol;
            var isField = symbolForFirstArg.Symbol is IFieldSymbol;

            var accurateCharacter = location
                .SourceTree
                .ToString()
                .Substring(location.SourceSpan.Start, location.SourceSpan.Length)
                .Split(new string[] { Environment.NewLine }, StringSplitOptions.None)
                .Last()
                .RegexIndexOf("Catch|Try");

            accurateCharacter = accurateCharacter > 0 ? accurateCharacter : lineSpan.Span.Start.Character;

            var accurateLine = lineSpan.Span.End.Line;

            return new CallInfo(
                MethodUniqueId: symbol.ToDisplayString(),
                MethodName: symbol.Name,
                ReturnType: symbol.ReturnType.ToDisplayString(),
                Parameters: symbol.Parameters.Select(p => $"{p.Type.ToDisplayString()} {p.Name}").ToList(),
                ParameterNames: symbol.Parameters.Select(p => p.Name).ToList(),
                FilePath: lineSpan.Path,
                Line: accurateLine + 1,
                Character: accurateCharacter + 1
            );
        }

        private void Execute(SourceProductionContext context, ImmutableArray<CallInfo> groups)
        {
            foreach (CallInfo call in groups.FastReverse())
            {

            }
        }

        record CallInfo(
            string MethodUniqueId,
            string MethodName,
            string ReturnType,
            List<string> Parameters,
            List<string> ParameterNames,
            string FilePath,
            int Line,
            int Character);
    }
}

