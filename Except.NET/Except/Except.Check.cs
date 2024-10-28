namespace System.Excepts
{
    public static partial class Except
    {
        public static bool Check(bool ok)
        {
            if (!ok)
            {
                throw new Exception();
            }

            return ok;
        }

        public static bool Check(bool ok, string message)
        {
            if (!ok)
            {
                throw new Exception(message);
            }

            return ok;
        }

        public static bool Check(bool ok, Exception exception)
        {
            if (!ok)
            {
                throw exception;
            }

            return ok;
        }

        public static bool Check<T>(bool ok) where T : Exception, new()
        {
            if (!ok)
            {
                throw new T();
            }

            return ok;
        }

        public static TSource Check<TSource>(this TSource result, bool ok)
        {
            if (!ok)
            {
                throw new Exception();
            }

            return result;
        }

        public static TSource Check<TSource>(this TSource result, bool ok, string message)
        {
            if (!ok)
            {
                throw new Exception(message);
            }

            return result;
        }

        public static TSource Check<TSource>(this TSource result, Func<TSource, bool> ok)
        {
            if (!ok(result))
            {
                throw new Exception();
            }

            return result;
        }

        public static TSource Check<TSource>(this TSource result, Func<TSource, bool> ok, string message)
        {
            if (!ok(result))
            {
                throw new Exception(message);
            }

            return result;
        }
    }

    public static partial class Except
    {
        public static object Check<T>(this object result, Func<dynamic, bool> ok, string message) where T : Exception, new()
        {
            if (!ok(result))
            {

                var ex = (T)Activator.CreateInstance(typeof(T), message);

                throw ex;
            }

            return result;
        }

        public static object Check<T>(this object result, Func<dynamic, bool> ok) where T : Exception
        {
            if (!ok(result))
            {
                if (typeof(T).GetConstructor(Type.EmptyTypes) == null)
                {
                    var ex = (T)Activator.CreateInstance(typeof(T), result);

                    throw ex;
                }

                var ex2 = (T)Activator.CreateInstance(typeof(T));

                throw ex2;
            }

            return result;
        }

        public static object Check<T>(this object result) where T : CheckException, new()
        {
            var ex = new T();

            ex.ToTest = result;

            if (!ex.Test())
            {
                throw ex;
            }

            return result;
        }

        public static object Check<T>(this object result, string message) where T : CheckException, new()
        {
            var ex = new T();

            ex.Message = message;

            ex.ToTest = result;

            if (!ex.Test())
            {
                throw ex;
            }

            return result;
        }
    }
}

// Generated
namespace System.Excepts
{
    public static partial class Except
    {
        public static int Check<T>(this int result, Func<int, bool> ok) where T : Exception, new()
        {
            if (!ok(result))
            {
                throw new T();
            }

            return result;
        }
    }
}

// Generated
namespace System.Excepts
{
    public static partial class Except
    {
        public static long Check<T>(this long result, Func<long, bool> ok) where T : Exception, new()
        {
            if (!ok(result))
            {
                throw new T();
            }

            return result;
        }
    }
}

// Generated
namespace System.Excepts
{
    public static partial class Except
    {
        public static float Check<T>(this float result, Func<float, bool> ok) where T : Exception, new()
        {
            if (!ok(result))
            {
                throw new T();
            }

            return result;
        }
    }
}

// Generated
namespace System.Excepts
{
    public static partial class Except
    {
        public static double Check<T>(this double result, Func<double, bool> ok) where T : Exception, new()
        {
            if (!ok(result))
            {
                throw new T();
            }

            return result;
        }
    }
}

// Generated
namespace System.Excepts
{
    public static partial class Except
    {
        public static bool Check<T>(this bool result, Func<bool, bool> ok) where T : Exception, new()
        {
            if (!ok(result))
            {
                throw new T();
            }

            return result;
        }
    }
}

// Generated
namespace System.Excepts
{
    public static partial class Except
    {
        public static char Check<T>(this char result, Func<char, bool> ok) where T : Exception, new()
        {
            if (!ok(result))
            {
                throw new T();
            }

            return result;
        }
    }
}

// Generated
namespace System.Excepts
{
    public static partial class Except
    {
        public static string Check<T>(this string result, Func<string, bool> ok) where T : Exception, new()
        {
            if (!ok(result))
            {
                throw new T();
            }

            return result;
        }
    }
}
