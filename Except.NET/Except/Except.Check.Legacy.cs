namespace System.Excepts
{
    public static partial class Except
    {
        public static void CheckLegacy(bool ok)
        {
            if (!ok)
            {
                throw new Exception();
            }
        }

        public static void CheckLegacy(bool ok, string message)
        {
            if (!ok)
            {
                throw new Exception(message);
            }
        }

        public static void CheckLegacy(bool ok, Exception exception)
        {
            if (!ok)
            {
                throw exception;
            }
        }

        public static void CheckLegacy<T>(bool ok) where T : Exception, new()
        {
            if (!ok)
            {
                throw new T();
            }
        }

        public static void CheckLegacy<T>(bool ok, string message) where T : Exception
        {
            if (!ok)
            {
                throw (T)Activator.CreateInstance(typeof(T), message);
            }
        }

        public static void CheckLegacy(bool[] conditions)
        {
            foreach (bool ok in conditions)
            {
                if (!ok)
                {
                    throw new Exception();
                }
            }
        }

        public static void CheckLegacy(bool[] conditions, Exception exception)
        {
            foreach (bool ok in conditions)
            {
                if (!ok)
                {
                    throw exception;
                }
            }
        }

        public static void CheckLegacy<T>(bool[] conditions) where T : Exception, new()
        {
            foreach (bool ok in conditions)
            {
                if (!ok)
                {
                    throw new T();
                }
            }
        }

        public static void CheckLegacy<T>(bool[] conditions, string message) where T : Exception
        {
            foreach (bool ok in conditions)
            {
                if (!ok)
                {
                    throw (T)Activator.CreateInstance(typeof(T), message);
                }
            }
        }
    }
}