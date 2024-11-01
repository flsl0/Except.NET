namespace System.Excepts
{
    public partial class Except
    {
        public static TSource Run<TSource>(this bool ok, Func<TSource> function) => function();

        public static TSource Run<TSource>(this TSource result, Func<TSource, TSource> function) => function(result);

        public static bool Run(Action function)
        {
            function();

            return true;
        }

        public static TSource Do<TSource>(this bool ok, Func<TSource> function) => function();

        public static TSource Do<TSource>(this TSource result, Func<TSource, TSource> function) => function(result);

        public static bool Do(Action function)
        {
            function();

            return true;
        }

        public static Exception Try(Action function)
        {
            try
            {
                function();
            }
            catch (Exception ex)
            {
                try
                {
                    ThreadIdToException.Add(ThreadId, ex);
                }
                catch
                {
                    ThreadIdToException[ThreadId] = ex;
                }

                return ex;
            }

            return null;
        }

        public static TSource Try<TSource>(Func<TSource> function)
        {
            try
            {
                return function();
            }
            catch (Exception ex)
            {
                try
                {
                    ThreadIdToException.Add(ThreadId, ex);
                }
                catch
                {
                    ThreadIdToException[ThreadId] = ex;
                }

                return default(TSource);
            }
        }
    }
}
