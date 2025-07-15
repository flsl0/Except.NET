using static System.Collections.Specialized.BitVector32;

namespace System.Excepts
{
    public partial class Except
    {
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
        // Generated
        public static TSource Try<TSource, T1>(Func<T1, TSource> function, T1 arg1)
        {
            if (ThreadIdToException.ContainsKey(ThreadId))
            {
                ThreadIdToException.Remove(ThreadId);
            }

            try
            {
                return (TSource)function(arg1);
            }
            catch (Exception ex)
            {
                ThreadIdToException.Add(ThreadId, ex);

                return default(TSource);
            }
        }

        // Generated
        public static TSource Try<TSource, T1, T2>(Func<T1, T2, TSource> function, T1 arg1, T2 arg2)
        {
            if (ThreadIdToException.ContainsKey(ThreadId))
            {
                ThreadIdToException.Remove(ThreadId);
            }

            try
            {
                return (TSource)function(arg1, arg2);
            }
            catch (Exception ex)
            {
                ThreadIdToException.Add(ThreadId, ex);

                return default(TSource);
            }
        }

        // Generated
        public static TSource Try<TSource, T1, T2, T3>(Func<T1, T2, T3, TSource> function, T1 arg1, T2 arg2, T3 arg3)
        {
            if (ThreadIdToException.ContainsKey(ThreadId))
            {
                ThreadIdToException.Remove(ThreadId);
            }

            try
            {
                return (TSource)function(arg1, arg2, arg3);
            }
            catch (Exception ex)
            {
                ThreadIdToException.Add(ThreadId, ex);

                return default(TSource);
            }
        }

        // Generated
        public static TSource Try<TSource, T1, T2, T3, T4>(Func<T1, T2, T3, T4, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (ThreadIdToException.ContainsKey(ThreadId))
            {
                ThreadIdToException.Remove(ThreadId);
            }

            try
            {
                return (TSource)function(arg1, arg2, arg3, arg4);
            }
            catch (Exception ex)
            {
                ThreadIdToException.Add(ThreadId, ex);

                return default(TSource);
            }
        }

        // Generated
        public static TSource Try<TSource, T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            if (ThreadIdToException.ContainsKey(ThreadId))
            {
                ThreadIdToException.Remove(ThreadId);
            }

            try
            {
                return (TSource)function(arg1, arg2, arg3, arg4, arg5);
            }
            catch (Exception ex)
            {
                ThreadIdToException.Add(ThreadId, ex);

                return default(TSource);
            }
        }

        // Generated
        public static TSource Try<TSource, T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            if (ThreadIdToException.ContainsKey(ThreadId))
            {
                ThreadIdToException.Remove(ThreadId);
            }

            try
            {
                return (TSource)function(arg1, arg2, arg3, arg4, arg5, arg6);
            }
            catch (Exception ex)
            {
                ThreadIdToException.Add(ThreadId, ex);

                return default(TSource);
            }
        }

        // Generated
        public static TSource Try<TSource, T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (ThreadIdToException.ContainsKey(ThreadId))
            {
                ThreadIdToException.Remove(ThreadId);
            }

            try
            {
                return (TSource)function(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            }
            catch (Exception ex)
            {
                ThreadIdToException.Add(ThreadId, ex);

                return default(TSource);
            }
        }

        // Generated
        public static TSource Try<TSource, T1, T2, T3, T4, T5, T6, T7, T8>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            if (ThreadIdToException.ContainsKey(ThreadId))
            {
                ThreadIdToException.Remove(ThreadId);
            }

            try
            {
                return (TSource)function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            }
            catch (Exception ex)
            {
                ThreadIdToException.Add(ThreadId, ex);

                return default(TSource);
            }
        }

        // Generated
        public static TSource Try<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            if (ThreadIdToException.ContainsKey(ThreadId))
            {
                ThreadIdToException.Remove(ThreadId);
            }

            try
            {
                return (TSource)function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
            }
            catch (Exception ex)
            {
                ThreadIdToException.Add(ThreadId, ex);

                return default(TSource);
            }
        }

        // Generated
        public static TSource Try<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            if (ThreadIdToException.ContainsKey(ThreadId))
            {
                ThreadIdToException.Remove(ThreadId);
            }

            try
            {
                return (TSource)function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
            }
            catch (Exception ex)
            {
                ThreadIdToException.Add(ThreadId, ex);

                return default(TSource);
            }
        }

        // Generated
        public static TSource Try<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            if (ThreadIdToException.ContainsKey(ThreadId))
            {
                ThreadIdToException.Remove(ThreadId);
            }

            try
            {
                return (TSource)function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
            }
            catch (Exception ex)
            {
                ThreadIdToException.Add(ThreadId, ex);

                return default(TSource);
            }
        }

        // Generated
        public static TSource Try<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        {
            if (ThreadIdToException.ContainsKey(ThreadId))
            {
                ThreadIdToException.Remove(ThreadId);
            }

            try
            {
                return (TSource)function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
            }
            catch (Exception ex)
            {
                ThreadIdToException.Add(ThreadId, ex);

                return default(TSource);
            }
        }

        // Generated
        public static TSource Try<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            if (ThreadIdToException.ContainsKey(ThreadId))
            {
                ThreadIdToException.Remove(ThreadId);
            }

            try
            {
                return (TSource)function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
            }
            catch (Exception ex)
            {
                ThreadIdToException.Add(ThreadId, ex);

                return default(TSource);
            }
        }

        // Generated
        public static TSource Try<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        {
            if (ThreadIdToException.ContainsKey(ThreadId))
            {
                ThreadIdToException.Remove(ThreadId);
            }

            try
            {
                return (TSource)function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
            }
            catch (Exception ex)
            {
                ThreadIdToException.Add(ThreadId, ex);

                return default(TSource);
            }
        }

        // Generated
        public static TSource Try<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        {
            if (ThreadIdToException.ContainsKey(ThreadId))
            {
                ThreadIdToException.Remove(ThreadId);
            }

            try
            {
                return (TSource)function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
            }
            catch (Exception ex)
            {
                ThreadIdToException.Add(ThreadId, ex);

                return default(TSource);
            }
        }

        // Generated
        public static TSource Try<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        {
            if (ThreadIdToException.ContainsKey(ThreadId))
            {
                ThreadIdToException.Remove(ThreadId);
            }

            try
            {
                return (TSource)function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
            }
            catch (Exception ex)
            {
                ThreadIdToException.Add(ThreadId, ex);

                return default(TSource);
            }
        }
    }
}
