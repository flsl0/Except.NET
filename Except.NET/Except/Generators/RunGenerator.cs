namespace System.Excepts.Generators
{
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

public static bool Run<{0}>(Action<{0}> function, {2})
{{
    function({1});

    return default;
}}

public static bool Run<TSource, {0}>(this TSource source, Action<{0}, TSource> function, {2})
{{
    function({1}, source);

    return default;
}}

public static TSource RunWithReturnArg<TSource, {0}>(this TSource source, Action<{0}, TSource> function, {2})
{{
    function({1}, source);

    return source;
}}
";
    }
}