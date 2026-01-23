using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using SourceGenerator;

class Program
{
    static void Main()
    {
        var source = @"
namespace Demo {
    public partial class Foo
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

        static void Test()
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

        var syntaxTree = CSharpSyntaxTree.ParseText(source);

        var refs = AppDomain.CurrentDomain.GetAssemblies()
            .Where(a => !a.IsDynamic && !string.IsNullOrWhiteSpace(a.Location))
            .Select(a => MetadataReference.CreateFromFile(a.Location))
            .Cast<MetadataReference>();

        var compilation = CSharpCompilation.Create(
            assemblyName: "Demo",
            syntaxTrees: new[] { syntaxTree },
            references: refs,
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

        IIncrementalGenerator generator = new IncrementalGenerator();
        var driver = CSharpGeneratorDriver.Create(generator);

        driver = (CSharpGeneratorDriver)driver.RunGeneratorsAndUpdateCompilation(compilation, out var updated, out var diags);

        Console.WriteLine("Diagnostics:");
        foreach (var d in diags) Console.WriteLine(d);

        var runResult = driver.GetRunResult();
        foreach (var result in runResult.Results)
        {
            foreach (var generated in result.GeneratedSources)
            {
                Console.WriteLine($"=== {generated.HintName} ===");
                Console.WriteLine(generated.SourceText.ToString());
            }
        }
    }
}
