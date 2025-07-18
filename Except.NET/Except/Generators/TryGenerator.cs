namespace System.Excepts.Generators
{
    public class TryGenerator : Generator
    {
        public override string Template { get; set; } = @"
// Generated
public static TSource Try<TSource, {0}>(Func<{0}, TSource> function, {2})
{{
    if (ThreadIdToException.ContainsKey(ThreadId))
    {{
        ThreadIdToException.Remove(ThreadId);
    }}

    try
    {{
        return (TSource)function({1});
    }}
    catch (Exception ex)
    {{
        ThreadIdToException.Add(ThreadId, ex);

        return default(TSource);
    }}
}}";
    }
}