using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using SourceGenerator;
using System.Collections.Generic;
using System.IO;
using Microsoft.CodeAnalysis.CSharp.Syntax;

class Program
{
    static void Main()
    {
        // 1) give the syntax tree a real path
        var projectRoot = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "HarnessInput"));
        Directory.CreateDirectory(projectRoot);

        var inputPath = Path.Combine(projectRoot, "Demo.cs");
        var source = @"
using ConsoleApp;
using System;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace ConsoleApp
{
    static class Program
    {
        public static extern TSource Try<TSource, T1, T2>(Func<T1, T2, TSource> function, T1 arg1, T2 arg2);

        /*public static TSource Try<TSource, T1, T2>(Func<T1, T2, TSource> function, T1 arg1, T2 arg2)
        {
            return function(arg1, arg2);
        }*/

        public static extern double Catch<T>(this double result, Action<Exception> function);

        public static extern TSource Catch<TSource>(this TSource result, Action<Exception> function);

        public static extern double Catch<T>(this double result, double @return);

        static double Divide(double a, double b) => a / b;

        static void Main(string[] args)
        {
            // Try(Divide, 10.0, 5.0).Catch<Exception>(double.PositiveInfinity);

            Try(Divide, 10.0, 5.0)
                .Catch((Exception ex) => Console.WriteLine(ex))
                .Catch<Exception>(Console.WriteLine);

            // Try(Divide, 10.0, 5.0).Catch<Exception>(10.0);

            double test2 = Try(Divide, 10.0, 5.0);
                //.Catch<Exception>(e => { Console.WriteLine(e); Console.WriteLine(e.Message); })
                //.Catch<Exception>(e => { Console.WriteLine(e); Console.WriteLine(e.Message); });

            // Try(Divide, 10.0, 5.0).Catch<Exception>(Console.WriteLine);

            var test = 12.ToString();
        }
    }
}";

        // (Optional) write it so it truly exists on disk (nice for debugging)
        File.WriteAllText(inputPath, source);

        var tree = CSharpSyntaxTree.ParseText(
            source,
            options: new CSharpParseOptions(LanguageVersion.Preview),
            path: inputPath
        );

        // 2) references: use TPA instead of AppDomain assemblies
        var refs = AppDomain.CurrentDomain.GetAssemblies()
                    .Where(a => !a.IsDynamic && !string.IsNullOrWhiteSpace(a.Location))
                    .Select(a => MetadataReference.CreateFromFile(a.Location))
                    .Cast<MetadataReference>();

        // 3) build compilation
        var compilation = CSharpCompilation.Create(
            assemblyName: "Demo",
            syntaxTrees: new[] { tree },
            references: refs,
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary)
        );

        // Helpful: if anything is unbound, you'll see it here
        var compDiags = compilation.GetDiagnostics();
        foreach (var d in compDiags.Where(d => d.Severity == DiagnosticSeverity.Error))
            Console.Error.WriteLine(d);

        // 4) run your incremental generator
        IIncrementalGenerator inc = new IncrementalGenerator();

        // As of current Roslyn APIs: wrap incremental generator as source generator for the driver
        var generator = inc.AsSourceGenerator();
        var driver = CSharpGeneratorDriver.Create(generator);

        driver = (CSharpGeneratorDriver)driver.RunGeneratorsAndUpdateCompilation(compilation, out var updated, out var genDiags);

        foreach (var d in genDiags) Console.Error.WriteLine(d);

        // Optional: dump generated sources
        var result = driver.GetRunResult();
        foreach (var r in result.Results)
            foreach (var gs in r.GeneratedSources)
            {
                Console.WriteLine($"=== {gs.HintName} ===");
                Console.WriteLine(gs.SourceText.ToString());
            }

        Console.WriteLine("Done.");
    }
}
