namespace System.Excepts.Generators;

public class RunGenerator : Generator
{
    public override string Template { get; set; } = @"
// Generated
public static TSource Run<TSource, {0}>(Func<{0}, TSource> function, {2})
    => function({1});

public static TSource Run<TSource, {0}>(this TSource source, Func<{0}, TSource> function, {2})
    => function({1});

public static TSource Run<TSource, {0}>(this TSource source, Func<{0}, TSource, TSource> function, {2})
    => function({1}, source);
";
}
