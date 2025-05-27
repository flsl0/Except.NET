namespace System.Excepts
{
    public partial class Except
    {
        public static TSource Run<TSource>(this bool ok, Func<TSource> function) => function();

        public static TSource Run<TSource>(this TSource result, Func<TSource, TSource> function) => function(result);

        public static TSource Run<TSource>(this TSource result, Func<TSource, dynamic> function) => function(result);

        public static TSource Run<TSource>(this TSource result, Func<dynamic, dynamic> function) => function(result);

        public static TSource Run<TSource>(this TSource result, Delegate function, params dynamic[] args) => (TSource) function.DynamicInvoke(args);

        public static TSource Run<TSource>(Delegate function, params dynamic[] args)
        {
            function.DynamicInvoke(args);

            return default(TSource);
        }

        public static bool Run(Action function)
        {
            function();

            return default;
        }

        public static bool Run(this bool ok, Action function)
        {
            function();

            return default;
        }

        public static T Run<T>(this T ok, Action function)
        {
            function();

            return default(T);
        }

        public static TSource Do<TSource>(this bool ok, Func<TSource> function) => function();

        public static TSource Do<TSource>(this TSource result, Func<TSource, TSource> function) => function(result);

        public static TSource Do<TSource>(this TSource result, Func<TSource, dynamic> function) => function(result);

        public static TSource Do<TSource>(this TSource result, Func<dynamic, dynamic> function) => function(result);

        public static TSource Do<TSource>(this TSource result, Delegate function, params dynamic[] args) => (TSource) function.DynamicInvoke(args);

        public static TSource Do<TSource>(Delegate function, params dynamic[] args)
        {
            function.DynamicInvoke(args);

            return default(TSource);
        }

        public static bool Do(Action function)
        {
            function();

            return default;
        }

        public static bool Do(this bool ok, Action function)
        {
            function();

            return default;
        }

        public static T Do<T>(this T ok, Action function)
        {
            function();

            return default(T);
        }

        public static Exception Try(Action function)
        {
            if (ThreadIdToException.ContainsKey(ThreadId))
            {
                ThreadIdToException.Remove(ThreadId);
            }

            try
            {
                function();
            }
            catch (Exception ex)
            {
                ThreadIdToException.Add(ThreadId, ex);

                return ex;
            }

            return null;
        }

        public static TSource Try<TSource>(Func<TSource> function)
        {
            if (ThreadIdToException.ContainsKey(ThreadId))
            {
                ThreadIdToException.Remove(ThreadId);
            }

            try
            {
                return function();
            }
            catch (Exception ex)
            {
                ThreadIdToException.Add(ThreadId, ex);

                return default(TSource);
            }
        }

        public static TSource Try<TSource>(Delegate function, params dynamic[] args)
        {
            if (ThreadIdToException.ContainsKey(ThreadId))
            {
                ThreadIdToException.Remove(ThreadId);
            }

            try
            {
                return (TSource) function.DynamicInvoke(args);
            }
            catch (Exception ex)
            {
                ThreadIdToException.Add(ThreadId, ex);

                return default(TSource);
            }
        }

        public static dynamic Try(Delegate function, params dynamic[] args)
        {
            if (ThreadIdToException.ContainsKey(ThreadId))
            {
                ThreadIdToException.Remove(ThreadId);
            }

            try
            {
                return function.DynamicInvoke(args);
            }
            catch (Exception ex)
            {
                ThreadIdToException.Add(ThreadId, ex);

                return default;
            }
        }
    }
}
