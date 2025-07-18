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

    public void Generate()
    {
        for(int i=1; i <= 16; i++)
        {
            string genericTypes = "";

            string genericArgs = "";

            string genericTypeAndArg = "";

            for (int j=1; j <= i; j++)
            {
                genericTypes += $"T{j}, ";

                genericArgs += $"arg{j}, ";

                genericTypeAndArg += $"T{j} arg{j}, ";
            }

            genericTypes = genericTypes.Substring(0, genericTypes.Length - 2);

            genericArgs = genericArgs.Substring(0, genericArgs.Length - 2);

            genericTypeAndArg = genericTypeAndArg.Substring(0, genericTypeAndArg.Length - 2);

            string result = string.Format(Template, genericTypes, genericArgs, genericTypeAndArg);

            Console.WriteLine(result);
        }
    }
}
