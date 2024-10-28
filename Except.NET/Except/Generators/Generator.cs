namespace System.Excepts.Generators;

public abstract class Generator
{
    protected static List<string> AllTypes = [
        "int",
        "long",
        "float",
        "double",
        "bool",
        "char",
        "string",
        "object",
    ];

    public abstract string Template { get; set; }

    public string Format(string type) => string.Format(Template, type);

    public void GenerateAll() => AllTypes
        .ForEachTry(Format)
        .CatchAll<AggregateException>(Console.WriteLine)
        .ForEach(Console.WriteLine);
}
