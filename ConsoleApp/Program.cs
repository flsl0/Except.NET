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
}

namespace Interceptors
{
    public static class CodeInterceptor
    {
        static Func<dynamic> test;

        [InterceptsLocation("""C:\Users\void\Documents\dev\SourceGeneratorTemplate-main\ConsoleApp\Program.cs""", line: 36, character: 28)]
        public static TSource Try<TSource, T1, T2>(Func<T1, T2, TSource> function, T1 arg1, T2 arg2)
        {
            test = () => function(arg1, arg2)!;

            return test();
        }

        /*[InterceptsLocation("""C:\Users\void\Documents\dev\SourceGeneratorTemplate-main\ConsoleApp\Program.cs""", line: 37, character: 18)]
        public static double Catch<T>(this double result, Action<Exception> function)
        {
            return default;
        }*/
    }
}
