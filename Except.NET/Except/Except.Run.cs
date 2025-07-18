namespace System.Excepts
{
    public partial class Except
    {
        public static T Run<T>(this bool ok, Func<T> function) => function();

        public static T RunWithReturnArg<T, U>(this T source, Func<T, U> function)
        {
            function(source);

            return source;
        }

        public static T RunWithReturnArg<T>(this T source, Action<T> function)
        {
            function(source);

            return source;
        }

        public static U Run<T, U>(this T source, Func<T, U> function)
        {
            return function(source);
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

        // Generated
        public static TSource Run<TSource, T1>(Func<T1, TSource> function, T1 arg1)
            => function(arg1);

        public static TSource Run<TSource, T1>(this TSource source, Func<T1, TSource> function, T1 arg1)
            => function(arg1);

        public static TSource Run<TSource, T1>(this TSource source, Func<T1, TSource, TSource> function, T1 arg1)
            => function(arg1, source);

        public static bool Run<T1>(Action<T1> function, T1 arg1)
        {
            function(arg1);

            return default;
        }

        public static bool Run<TSource, T1>(this TSource source, Action<T1, TSource> function, T1 arg1)
        {
            function(arg1, source);

            return default;
        }

        public static TSource RunWithReturnArg<TSource, T1>(this TSource source, Action<T1, TSource> function, T1 arg1)
        {
            function(arg1, source);

            return source;
        }


        // Generated
        public static TSource Run<TSource, T1, T2>(Func<T1, T2, TSource> function, T1 arg1, T2 arg2)
            => function(arg1, arg2);

        public static TSource Run<TSource, T1, T2>(this TSource source, Func<T1, T2, TSource> function, T1 arg1, T2 arg2)
            => function(arg1, arg2);

        public static TSource Run<TSource, T1, T2>(this TSource source, Func<T1, T2, TSource, TSource> function, T1 arg1, T2 arg2)
            => function(arg1, arg2, source);

        public static bool Run<T1, T2>(Action<T1, T2> function, T1 arg1, T2 arg2)
        {
            function(arg1, arg2);

            return default;
        }

        public static bool Run<TSource, T1, T2>(this TSource source, Action<T1, T2, TSource> function, T1 arg1, T2 arg2)
        {
            function(arg1, arg2, source);

            return default;
        }

        public static TSource RunWithReturnArg<TSource, T1, T2>(this TSource source, Action<T1, T2, TSource> function, T1 arg1, T2 arg2)
        {
            function(arg1, arg2, source);

            return source;
        }


        // Generated
        public static TSource Run<TSource, T1, T2, T3>(Func<T1, T2, T3, TSource> function, T1 arg1, T2 arg2, T3 arg3)
            => function(arg1, arg2, arg3);

        public static TSource Run<TSource, T1, T2, T3>(this TSource source, Func<T1, T2, T3, TSource> function, T1 arg1, T2 arg2, T3 arg3)
            => function(arg1, arg2, arg3);

        public static TSource Run<TSource, T1, T2, T3>(this TSource source, Func<T1, T2, T3, TSource, TSource> function, T1 arg1, T2 arg2, T3 arg3)
            => function(arg1, arg2, arg3, source);

        public static bool Run<T1, T2, T3>(Action<T1, T2, T3> function, T1 arg1, T2 arg2, T3 arg3)
        {
            function(arg1, arg2, arg3);

            return default;
        }

        public static bool Run<TSource, T1, T2, T3>(this TSource source, Action<T1, T2, T3, TSource> function, T1 arg1, T2 arg2, T3 arg3)
        {
            function(arg1, arg2, arg3, source);

            return default;
        }

        public static TSource RunWithReturnArg<TSource, T1, T2, T3>(this TSource source, Action<T1, T2, T3, TSource> function, T1 arg1, T2 arg2, T3 arg3)
        {
            function(arg1, arg2, arg3, source);

            return source;
        }


        // Generated
        public static TSource Run<TSource, T1, T2, T3, T4>(Func<T1, T2, T3, T4, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
            => function(arg1, arg2, arg3, arg4);

        public static TSource Run<TSource, T1, T2, T3, T4>(this TSource source, Func<T1, T2, T3, T4, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
            => function(arg1, arg2, arg3, arg4);

        public static TSource Run<TSource, T1, T2, T3, T4>(this TSource source, Func<T1, T2, T3, T4, TSource, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
            => function(arg1, arg2, arg3, arg4, source);

        public static bool Run<T1, T2, T3, T4>(Action<T1, T2, T3, T4> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            function(arg1, arg2, arg3, arg4);

            return default;
        }

        public static bool Run<TSource, T1, T2, T3, T4>(this TSource source, Action<T1, T2, T3, T4, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            function(arg1, arg2, arg3, arg4, source);

            return default;
        }

        public static TSource RunWithReturnArg<TSource, T1, T2, T3, T4>(this TSource source, Action<T1, T2, T3, T4, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            function(arg1, arg2, arg3, arg4, source);

            return source;
        }


        // Generated
        public static TSource Run<TSource, T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
            => function(arg1, arg2, arg3, arg4, arg5);

        public static TSource Run<TSource, T1, T2, T3, T4, T5>(this TSource source, Func<T1, T2, T3, T4, T5, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
            => function(arg1, arg2, arg3, arg4, arg5);

        public static TSource Run<TSource, T1, T2, T3, T4, T5>(this TSource source, Func<T1, T2, T3, T4, T5, TSource, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
            => function(arg1, arg2, arg3, arg4, arg5, source);

        public static bool Run<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            function(arg1, arg2, arg3, arg4, arg5);

            return default;
        }

        public static bool Run<TSource, T1, T2, T3, T4, T5>(this TSource source, Action<T1, T2, T3, T4, T5, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            function(arg1, arg2, arg3, arg4, arg5, source);

            return default;
        }

        public static TSource RunWithReturnArg<TSource, T1, T2, T3, T4, T5>(this TSource source, Action<T1, T2, T3, T4, T5, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            function(arg1, arg2, arg3, arg4, arg5, source);

            return source;
        }


        // Generated
        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
            => function(arg1, arg2, arg3, arg4, arg5, arg6);

        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6>(this TSource source, Func<T1, T2, T3, T4, T5, T6, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
            => function(arg1, arg2, arg3, arg4, arg5, arg6);

        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6>(this TSource source, Func<T1, T2, T3, T4, T5, T6, TSource, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, source);

        public static bool Run<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6);

            return default;
        }

        public static bool Run<TSource, T1, T2, T3, T4, T5, T6>(this TSource source, Action<T1, T2, T3, T4, T5, T6, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, source);

            return default;
        }

        public static TSource RunWithReturnArg<TSource, T1, T2, T3, T4, T5, T6>(this TSource source, Action<T1, T2, T3, T4, T5, T6, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, source);

            return source;
        }


        // Generated
        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7>(this TSource source, Func<T1, T2, T3, T4, T5, T6, T7, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7>(this TSource source, Func<T1, T2, T3, T4, T5, T6, T7, TSource, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, source);

        public static bool Run<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

            return default;
        }

        public static bool Run<TSource, T1, T2, T3, T4, T5, T6, T7>(this TSource source, Action<T1, T2, T3, T4, T5, T6, T7, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, source);

            return default;
        }

        public static TSource RunWithReturnArg<TSource, T1, T2, T3, T4, T5, T6, T7>(this TSource source, Action<T1, T2, T3, T4, T5, T6, T7, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, source);

            return source;
        }


        // Generated
        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8>(this TSource source, Func<T1, T2, T3, T4, T5, T6, T7, T8, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8>(this TSource source, Func<T1, T2, T3, T4, T5, T6, T7, T8, TSource, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, source);

        public static bool Run<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

            return default;
        }

        public static bool Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8>(this TSource source, Action<T1, T2, T3, T4, T5, T6, T7, T8, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, source);

            return default;
        }

        public static TSource RunWithReturnArg<TSource, T1, T2, T3, T4, T5, T6, T7, T8>(this TSource source, Action<T1, T2, T3, T4, T5, T6, T7, T8, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, source);

            return source;
        }


        // Generated
        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this TSource source, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this TSource source, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TSource, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, source);

        public static bool Run<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

            return default;
        }

        public static bool Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this TSource source, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, source);

            return default;
        }

        public static TSource RunWithReturnArg<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this TSource source, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, source);

            return source;
        }


        // Generated
        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this TSource source, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this TSource source, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TSource, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, source);

        public static bool Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

            return default;
        }

        public static bool Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this TSource source, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, source);

            return default;
        }

        public static TSource RunWithReturnArg<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this TSource source, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, source);

            return source;
        }


        // Generated
        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this TSource source, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this TSource source, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TSource, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, source);

        public static bool Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

            return default;
        }

        public static bool Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this TSource source, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, source);

            return default;
        }

        public static TSource RunWithReturnArg<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this TSource source, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, source);

            return source;
        }


        // Generated
        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this TSource source, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this TSource source, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TSource, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, source);

        public static bool Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

            return default;
        }

        public static bool Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this TSource source, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, source);

            return default;
        }

        public static TSource RunWithReturnArg<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this TSource source, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, source);

            return source;
        }


        // Generated
        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this TSource source, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this TSource source, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TSource, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, source);

        public static bool Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

            return default;
        }

        public static bool Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this TSource source, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, source);

            return default;
        }

        public static TSource RunWithReturnArg<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this TSource source, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, source);

            return source;
        }


        // Generated
        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this TSource source, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this TSource source, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TSource, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, source);

        public static bool Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

            return default;
        }

        public static bool Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this TSource source, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, source);

            return default;
        }

        public static TSource RunWithReturnArg<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this TSource source, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, source);

            return source;
        }


        // Generated
        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this TSource source, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this TSource source, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TSource, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, source);

        public static bool Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

            return default;
        }

        public static bool Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this TSource source, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, source);

            return default;
        }

        public static TSource RunWithReturnArg<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this TSource source, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, source);

            return source;
        }


        // Generated
        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);

        public static TSource Run<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this TSource source, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TSource> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
            => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);

        public static bool Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        {
            function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);

            return default;
        }
    }
}
