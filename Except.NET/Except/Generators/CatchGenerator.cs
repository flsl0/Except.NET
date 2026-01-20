namespace System.Excepts.Generators
{
    public class CatchGenerator : Generator
    {
        private static readonly object LockObj = new object();

        private static CatchGenerator _instance;

        public static CatchGenerator Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new CatchGenerator();
                    }
                }

                return _instance;
            }
        }

        public override string Template { get; set; } = @"
// Generated
namespace System.Excepts
{{
    public static partial class Except
    {{
        public static {0} Catch<T>(this {0} result, Func<Exception, {0}> function) where T : Exception, new()
        {{
            if (!ThreadIdToException.ContainsKey(ThreadId))
            {{
                return result;
            }}

            var ex = ThreadIdToException[ThreadId];

            if (typeof(T) != typeof(Exception) && typeof(T) != ex.GetType())
            {{
                return result;
            }}

            var res = function((T)ex);

            ThreadIdToException.Remove(ThreadId);

            return res;
        }}

        public static {0} Catch<T>(this {0} result, Action<Exception> function) where T : Exception, new()
        {{
            if (!ThreadIdToException.ContainsKey(ThreadId))
            {{
                return result;
            }}

            var ex = ThreadIdToException[ThreadId];

            if (typeof(T) != typeof(Exception) && typeof(T) != ex.GetType())
            {{
                return result;
            }}

            function((T)ex);

            ThreadIdToException.Remove(ThreadId);

            return default({0});
        }}

        public static {0} Catch<T>(this {0} result, {0} newResult) where T : Exception, new()
        {{
            if (!ThreadIdToException.ContainsKey(ThreadId))
            {{
                return result;
            }}

            var ex = ThreadIdToException[ThreadId];

            if (typeof(T) != typeof(Exception) && typeof(T) != ex.GetType())
            {{
                return result;
            }}

            ThreadIdToException.Remove(ThreadId);

            return newResult;
        }}
    }}
}}";

        // public void Load(Type type) => Except.Try(() => _Load(type)).Catch(Console.WriteLine);

        // private void _Load(Type type)
        // {
        //     CSharpCompilation compilation = CSharpCompilation.Create(
        //         assemblyName: Path.GetRandomFileName(),
        //         syntaxTrees: new[] { CSharpSyntaxTree.ParseText(Format(type.ToString())) },
        //         references: new MetadataReference[]
        //         {
        //             MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
        //             MetadataReference.CreateFromFile(typeof(Enumerable).Assembly.Location),
        //             MetadataReference.CreateFromFile(Assembly.GetAssembly(type).Location),
        //             MetadataReference.CreateFromFile(typeof(Except).Assembly.Location)
        //         },
        //         options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

        //     using var ms = new MemoryStream();

        //     compilation.Emit(ms).Check<CompilationFailed>(r => r.Success);

        //     ms.Seek(0, SeekOrigin.Begin);

        //     Assembly.Load(ms.ToArray());
        // }
    }
}
