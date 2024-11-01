namespace System.Excepts
{
    public static partial class Except
    {
        public static void Throw<TEx>(TEx exArg) where TEx : Exception
        {
            throw exArg;
            // var ex = ThreadIdToException[ThreadId];

            // if (typeof(TEx) != typeof(Exception) && typeof(TEx) != ex.GetType())
            // {
            //     return;
            // }

            // throw ex;
        }
    }
}

