namespace System.Excepts.Generators
{
    public class CheckGenerator : Generator
    {
        private static readonly object LockObj = new object();

        private static CheckGenerator _instance;

        public static CheckGenerator Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new CheckGenerator();
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
        public static {0} Check<T>(this {0} result, Func<{0}, bool> ok) where T : Exception, new()
        {{
            if (!ok(result))
            {{
                throw new T();
            }}

            return result;
        }}
    }}
}}";
    }
}
