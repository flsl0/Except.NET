using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

using static System.Excepts.Except;

[MemoryDiagnoser(false)]
class ExceptBenchmark
{

    double Divide(double a, double b)
    {
        Check(b != 0); // will throw an exception if b == 0

        return a / b;
    }

    bool TryDivide(double a, double b, out double result)
    {
        result = default;

        try
        {
            result = Divide(10.0, 2.0);

            return true;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
        }

        return false;
    }

    [Benchmark]
    public void TryBlock()
    {
        TryDivide(10.0, 2.0, out var result);
    }

    [Benchmark]
    public void TryInvoke()
    {
        Try(() => Divide(10.0, 2.0)).Catch(Throw);
    }

    [Benchmark]
    public void TryDynamicInvoke()
    {
        Try(Divide, 10.0, 2.0).Catch(Throw);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ManualConfig benchmark_config = ManualConfig.CreateEmpty();
        benchmark_config.AddColumnProvider(DefaultColumnProviders.Instance);
        benchmark_config.AddLogger(ConsoleLogger.Default);
        benchmark_config.AddExporter(DefaultExporters.JsonFull);

        var job = Job.Default.WithCustomBuildConfiguration("Benchmarks");
        job.Meta.IsDefault = true;
        benchmark_config.AddJob(job);

        benchmark_config.AddJob(job);

        BenchmarkSwitcher
            .FromAssembly(typeof(Program).Assembly)
            .Run(args, benchmark_config);
    }
}
