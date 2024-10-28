namespace System.Excepts
{
    public partial class Except
    {
        public static List<Exception> ForEach<TSource>(IEnumerable<TSource> list, Action<TSource> function)
        {
            List<Exception> exceptions = new List<Exception>();

            foreach (TSource obj in list)
            {
                try
                {
                    function(obj);
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                }
            }

            if (exceptions.Count > 0)
            {
                try
                {
                    ThreadIdToExceptions.Add(ThreadId, exceptions);
                }
                catch
                {
                    ThreadIdToExceptions[ThreadId] = exceptions;
                }

                return exceptions;
            }

            return null;
        }

        public static List<TSource> ForEach<TArg, TSource>(IEnumerable<TArg> list, Func<TArg, TSource> function)
        {
            List<TSource> results = new();

            List<Exception> exceptions = new();

            foreach (TArg obj in list)
            {
                try
                {
                    results.Add(function(obj));
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                }
            }

            if (exceptions.Count > 0)
            {
                try
                {
                    ThreadIdToExceptions.Add(ThreadId, exceptions);
                }
                catch
                {
                    ThreadIdToExceptions[ThreadId] = exceptions;
                }
            }

            return results;
        }

        public static IEnumerable<TSource> ForEachTry<TSource>(this IEnumerable<TSource> list, Action<TSource> function)
        {
            List<Exception> exceptions = new List<Exception>();

            foreach (TSource obj in list)
            {
                try
                {
                    function(obj);
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                }
            }

            if (exceptions.Count > 0)
            {
                try
                {
                    ThreadIdToExceptions.Add(ThreadId, exceptions);
                }
                catch
                {
                    ThreadIdToExceptions[ThreadId] = exceptions;
                }
            }

            return list;
        }

        public static List<TSource> ForEachTry<TSource>(this List<TSource> list, Func<TSource, TSource> function)
        {
            List<TSource> newList = new();

            List<Exception> exceptions = new List<Exception>();

            foreach (TSource obj in list)
            {
                try
                {
                    newList.Add(function(obj));
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                }
            }

            if (exceptions.Count > 0)
            {
                try
                {
                    ThreadIdToExceptions.Add(ThreadId, exceptions);
                }
                catch
                {
                    ThreadIdToExceptions[ThreadId] = exceptions;
                }
            }

            return newList;
        }
    }
}
