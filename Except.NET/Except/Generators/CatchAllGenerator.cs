namespace System.Excepts.Generators
{
    public class CatchAllGenerator : Generator
    {
        private static readonly object LockObj = new object();

        private static CatchAllGenerator _instance;

        public static CatchAllGenerator Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new CatchAllGenerator();
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
        public static List<{0}> CatchAll<T>(this List<{0}> result, Action<T> function)
        {{
            if (!ThreadIdToExceptions.ContainsKey(ThreadId))
            {{
                return result;
            }}

            var ex = ThreadIdToExceptions[ThreadId];

            function((T)Activator.CreateInstance(typeof(T), ex));

            return result;
        }}
    }}
}}";
    }
}
